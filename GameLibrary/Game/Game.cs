
using OpenTK;
using GameEngine;
using GameLibrary.PresentsLauncher;

namespace GameLibrary.Game
{
    public  class Game : Scene
    {
        /// <summary>
        /// Статическая ссылка на класс
        /// </summary>
        public static Game instance = null;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Game()
        {
            if (instance == null)
                instance = this;

            var gameConstructor = new GameObjectConstructor();


            gameObjects.Add(new PresentsLauncherPrize());
            gameObjects.Add(new PresentsLauncherDuck());
            gameObjects.Add(gameConstructor.CreateCloud(new Vector2(60, 360)));
            gameObjects.Add(gameConstructor.CreateCloud(new Vector2(-320, 280)));
            gameObjects.Add(gameConstructor.CreateCloud(new Vector2(380, 280)));
            gameObjects.Add(gameConstructor.CreateCloud(new Vector2(720, 360)));
            gameObjects.Add(gameConstructor.CreateGround(new Vector2(650, 340)));
            gameObjects.Add(gameConstructor.CreatePlayer(true, new Vector2(100, 0)));
            gameObjects.Add(gameConstructor.CreatePlayer(false, new Vector2(-100, 0)));

        }

        /// <summary>
        /// Рендеринг кадра
        /// </summary>
        public override void Rendering()
        {
            Time.UpdateTime();
            FPS.Update(Time.DeltaTime);


            for (int i = 0; i < gameObjects.Count; i++)
            {
                gameObjects[i].Update();

                if (gameObjects[i].Texture != null)
                    Sprite.Draw(gameObjects[i]);
            }

            if (Time.CurrentTime >= 60)
                EndGame();

            RemoveRenderingGameObjects();
            AddRenderingGameObjects();

        }

        /// <summary>
        /// Метод, характеризующий конец игры
        /// </summary>
        protected override void EndGame()
        {
            if (Player.Player.FirstPlayerScore > Player.Player.SecondPlayerScore)
                GameEvents.EndGame(true);
            else if (Player.Player.FirstPlayerScore < Player.Player.SecondPlayerScore)
                GameEvents.EndGame(false);
            else
                GameEvents.EndGame();
        }

    }
}
