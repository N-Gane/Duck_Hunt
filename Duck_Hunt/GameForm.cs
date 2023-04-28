using OpenTK.Graphics.OpenGL;
using System;
using System.Drawing;
using System.Windows.Forms;
using GameEngine;
using GameLibrary.Game;

namespace Duck_Hunt
{
    public partial class GameForm : Form
    {
        Game game = new Game();

        public GameForm()
        {
            InitializeComponent();

            GameEvents.ChangeBulletCount += ChangeBulletCount;
            GameEvents.EndGame += EndGame;
            GameEvents.ChangeTypeBullet += ChangeTypeBullet;
            GameEvents.ChangeCountDuck += ChangeCountDuck;
        }

        private void ChangeBulletCount(bool firstPlayer, int value)
        {
            if (firstPlayer)
                CountBulletLeft.Text = value.ToString();
            else
                CountBulletRight.Text = value.ToString();
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
                    BackColor = Color.FromArgb(69, 0, 0);
                    labelWin.Text = "The left player win";
                }
                else
                {
                    BackColor = Color.FromArgb(46, 0, 69);
                    labelWin.Text = "The right player win";
                }
            }
            else
            {
                BackColor = Color.FromArgb(28, 74, 25);
                labelWin.Text = "Draw";
            }
        }

        private void ChangeTypeBullet(bool firstPlayer, string value)
        {
            if (firstPlayer)
                TypeBulletLeft.Text = value.ToString();
            else
                TypeBulletRight.Text = value.ToString();
        }

        private void ChangeCountDuck(bool firstPlayer, int value)
        {
            if (firstPlayer)
                DownedDuksLeft.Text = value.ToString();
            else
                DownedDuksRight.Text = value.ToString();
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
            BackgroundImage = null;

            isRendring = true;

            gLControl.Visible = true;
            Play.Visible = false;
            panelLeft.Visible = true;
            panelRight.Visible = true;
            label2.Visible = true;
            label5.Visible = true;
        }

        private void GLControl_Paint(object sender, PaintEventArgs e)
        {
            if (isRendring)
                Render();

            gLControl.Invalidate();
        }
    }
}
