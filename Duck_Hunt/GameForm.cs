using System;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using GameEngine;

using GameLibrary.Game;
using GameLibrary.Player;

using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Duck_Hunt
{
    public partial class GameForm : Form
    {
        private static TcpClient Client = new TcpClient();
        private static NetworkStream Stream;
        private bool RedConnected, BlueConnected;
        private static int CurrentPlayerId;
        private readonly Player[] Players = new Player[2];
        private bool _gameStarted = false; // Флаг начала игры

        private class ReceivedMessage
        {
            public bool Loser;
            public int DownedDuks, BulletCount;
            public string BulletType;
        }

        private Game game = new Game();

        public GameForm()
        {
            InitializeComponent();
            if (Gamemodes.Multiplayer)
                try
                {
                    var connection = new Connection();
                    connection.ShowDialog();
                    if (connection.DialogResult is DialogResult.Cancel)
                    {
                        var mainMenu = new MainMenu();
                        mainMenu.ShowDialog();
                        Disconnect();
                    }

                    try
                    {
                        Client = new TcpClient();
                        Client.Connect(ConnectionOptions.IP, ConnectionOptions.Port);
                        Stream = Client.GetStream();
                    }
                    catch
                    {
                        MessageBox.Show("Could not connect to the server."
                                        + Environment.NewLine
                                        + "Server is offline");
                        Disconnect();
                    }
                    var receiveThread = new Thread(ReceiveMessage);
                    receiveThread.Start();
                    Stream.Write(
                        Encoding.Unicode.GetBytes("Someone has connected"),
                        0,
                        Encoding.Unicode.GetBytes("Someone has connected").Length);
                    var colorChoosing = new ColorChoosing();
                    colorChoosing.ShowDialog();
                    if (colorChoosing.DialogResult is DialogResult.Cancel)
                    {
                        var mainMenu = new MainMenu();
                        mainMenu.ShowDialog();
                        Disconnect();
                    }
                    Stream.Write(
                        Encoding.Unicode.GetBytes(ConnectionOptions.PlayerName),
                        0,
                        Encoding.Unicode.GetBytes(ConnectionOptions.PlayerName).Length);
                    switch (ConnectionOptions.PlayerName)
                    {
                        case "Red":
                            RedConnected = true;
                            CurrentPlayerId = 0;
                            break;

                        case "Blue":
                            BlueConnected = true;
                            CurrentPlayerId = 1;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            Players = game.gameObjects
    .Where(obj => obj is Player)
    .Cast<Player>()
    .ToArray();

            GameEvents.ChangeBulletCount += ChangeBulletCount;
            GameEvents.EndGame += EndGame;
            GameEvents.ChangeTypeBullet += ChangeTypeBullet;
            GameEvents.ChangeCountDuck += ChangeCountDuck;

            StartSendingPlayerInfo();
        }

        private void ChangeBulletCount(bool firstPlayer, int value)
        {
            if (firstPlayer)
                CountBulletLeft.Text = value.ToString();
            //  else
            //   CountBulletRight.Text = value.ToString();

            //    SendPlayerInfo();
        }

        private void EndGame(bool? winPlayer = null)
        {
            isRendring = false;

            labelWin.Visible = true;
            gLControl.Visible = false;
            Play.Visible = false;
            panelLeft.Visible = false;
            panelRight.Visible = false;
            label2.Visible = false;
            BackgroundImage = null;

            if (winPlayer != null)
            {
                if ((bool)winPlayer)
                {
                    BackColor = Color.FromArgb(0, 255, 0);
                    labelWin.Text = "WIN";
                }
                else
                {
                    BackColor = Color.FromArgb(255, 0, 0);
                    labelWin.Text = "LOSE";
                }
            }
            else
            {
                BackColor = Color.FromArgb(255, 255, 0);
                labelWin.Text = "Draw";
            }

            StopSendingPlayerInfo();
        }

        private void ChangeTypeBullet(bool firstPlayer, string value)
        {
            if (firstPlayer)
                TypeBulletLeft.Text = value.ToString();
            //    else
            //    TypeBulletRight.Text = value.ToString();

            //     SendPlayerInfo();
        }

        private void ChangeCountDuck(bool firstPlayer, int value)
        {
            if (firstPlayer)
                DownedDuksLeft.Text = value.ToString();
            else
                DownedDuksRight.Text = value.ToString();

            //    SendPlayerInfo();
        }

        private bool _loaded;
        private bool isRendring = false;

        private void GLControl_Load(object sender, EventArgs e)
        {
            GL.Enable(EnableCap.Blend);
            GL.Enable(EnableCap.Texture2D);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Viewport(0, 0, gLControl.Width, gLControl.Height);

            _loaded = true;

            gLControl.Invalidate();

            gLControl.Visible = false;
            panelLeft.Visible = false;
            panelRight.Visible = false;
            label2.Visible = false;
            labelWin.Visible = false;
            label5.Visible = false;
        }

        private void Render()
        {
            label5.Text = FPS.CurrAccount.ToString();
            label2.Text = Time.CurrentTime.ToString();

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.ClearColor(System.Drawing.Color.CornflowerBlue);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-Width / 2, Width / 2, Height / 2, -Height / 2, 0d, 1d);

            game.Rendering();

            gLControl.SwapBuffers();
        }

        private void GLControl_Resize(object sender, EventArgs e)
        {
            if (!_loaded)
                return;
            GL.Viewport(0, 0, gLControl.Width, gLControl.Height);
            gLControl.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Отправляем серверу сообщение о старте игры
                string startGameMessage = "StartGame";
                byte[] data = Encoding.Unicode.GetBytes(startGameMessage);
                Stream.Write(data, 0, data.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending start game message: {ex.Message}");
            }

            StartGame();
        }

        private void StartGame()
        {
            // Логика включения игрового режима
            BackgroundImage = null;

            isRendring = true;

            gLControl.Visible = true;
            Play.Visible = false;
            panelLeft.Visible = true;
            panelRight.Visible = true;
            label2.Visible = true;
            label5.Visible = true;

            _gameStarted = true; // Устанавливаем флаг, что игра началась
                                 //   MessageBox.Show("The game has started!");
        }

        private void GLControl_Paint(object sender, PaintEventArgs e)
        {
            if (isRendring)
                Render();

            gLControl.Invalidate();
        }

        public class OpponentInfo
        {
            public bool IsFirstPlayer { get; set; }
            public int Score { get; set; }
            public int BulletCount { get; set; }
            public string BulletType { get; set; }

            public float X { get; set; }
            public float Y { get; set; }
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    var data = new byte[256];
                    var builder = new StringBuilder();
                    do
                    {
                        var bytes = Stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    } while (Stream.DataAvailable);

                    var message = builder.ToString();

                    //    Debug.WriteLine("Message from another client " + message);

                    if (message == "StartGame")
                    {
                        // Логика запуска игры
                        this.Invoke((MethodInvoker)delegate
                        {
                            StartGame();
                        });
                        continue;
                    }

                    if (message.StartsWith("{") && message.EndsWith("}"))
                    {
                        var jsonPattern = @"\{[^{}]*\}"; // Находит корректные JSON-объекты

                        foreach (Match match in Regex.Matches(message, jsonPattern))
                        {
                            try
                            {
                                var opponentInfo = Newtonsoft.Json.JsonConvert.DeserializeObject<OpponentInfo>(match.Value);

                                bool isOpponentFirstPlayer = opponentInfo.IsFirstPlayer;
                                int score = opponentInfo.Score;
                                int bulletCount = opponentInfo.BulletCount;
                                string bulletType = opponentInfo.BulletType;
                                float positionX = opponentInfo.X;
                                float positionY = opponentInfo.Y;

                                // Обновляем UI

                                // Обновление позиции игрока
                                foreach (var player in Players)
                                {
                                    if (!player.isFirstPlayer) // Ищем игрока, у которого IsFirstPlayer = false
                                    {
                                        Player.SecondPlayerScore = score;

                                        Console.WriteLine(Player.FirstPlayerScore.ToString());
                                        Console.WriteLine(Player.SecondPlayerScore.ToString());

                                        player.Position.Location = new Vector2(positionX, positionY);
                                        //  Console.WriteLine($"Updated opponent position: X = {positionX}, Y = {positionY}");
                                    }
                                }

                                this.Invoke((MethodInvoker)delegate
                                                              {
                                                                  CountBulletRight.Text = bulletCount.ToString();
                                                                  TypeBulletRight.Text = bulletType;
                                                                  DownedDuksRight.Text = Player.SecondPlayerScore.ToString();
                                                                  //   DownedDuksRight.Text = score.ToString();
                                                              });
                                // Для отладки в консоли
                                //    Console.WriteLine($"IsFirstPlayer: {isOpponentFirstPlayer}, Score: {score}, BulletCount: {bulletCount}, BulletType: {bulletType}, Position: X = {positionX}, Y = {positionY}");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error processing JSON: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        switch (message)
                        {
                            case "Red has connected":
                                {
                                    RedConnected = true;
                                    ConnectionOptions.NameRedIsTaken = true;
                                    if (!BlueConnected) continue;
                                    Stream.Write(Encoding.Unicode.GetBytes("Both players has connected"), 0, Encoding.Unicode.GetBytes("Both players has connected").Length);
                                    break;
                                }
                            case "Blue has connected":
                                {
                                    BlueConnected = true;
                                    ConnectionOptions.NameBlueIsTaken = true;
                                    if (!RedConnected) continue;
                                    Stream.Write(Encoding.Unicode.GetBytes("Both players has connected"), 0, Encoding.Unicode.GetBytes("Both players has connected").Length);
                                    break;
                                }
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error receiving message: {ex.Message}");
                    Disconnect();
                }
            }
        }

        private void SendPlayerInfo()
        {
            try
            {
                foreach (var player in Players)
                {
                    // Проверяем, является ли игрок первым
                    bool isFirstPlayer = player.isFirstPlayer;
                    if (isFirstPlayer)
                    {
                        var currentPlayer = player;

                        var playerInfo = new
                        {
                            IsFirstPlayer = true,
                            Score = Player.FirstPlayerScore,
                            BulletCount = currentPlayer.BulletBox.Bullet.Count,
                            BulletType = currentPlayer.BulletBox.Bullet.ToString(),

                            X = currentPlayer.Position.Location.X, // Координата X
                            Y = currentPlayer.Position.Location.Y  // Координата Y
                        };

                        string message = Newtonsoft.Json.JsonConvert.SerializeObject(playerInfo);
                        byte[] data = Encoding.Unicode.GetBytes(message);
                        Stream.Write(data, 0, data.Length);

                        break; // Завершаем цикл, так как игрок найден и данные отправлены
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending player info: {ex.Message}");
            }
        }

        private bool _isSendingInfo = true; // Флаг для управления отправкой
        private const int SendInterval = 500; // Интервал отправки данных в миллисекундах

        // Асинхронный метод для периодической отправки данных
        private async Task StartSendingPlayerInfoAsync()
        {
            while (_isSendingInfo)
            {
                if (_gameStarted) // Проверяем, началась ли игра
                {
                    try
                    {
                        SendPlayerInfo();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error sending player info: {ex.Message}");
                    }
                }
                await Task.Delay(SendInterval); // Задержка перед следующим вызовом
            }
        }

        // Запуск автоматической отправки данных
        private void StartSendingPlayerInfo()
        {
            _isSendingInfo = true;
            _ = StartSendingPlayerInfoAsync(); // Запуск асинхронного метода
        }

        // Остановка автоматической отправки данных
        private void StopSendingPlayerInfo()
        {
            _isSendingInfo = false;
        }

        private static void Disconnect()
        {
            Stream?.Close();
            Client?.Close();
            Environment.Exit(0);
        }
    }
}