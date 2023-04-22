
using OpenTK;
using GameEngine;

namespace GameLibrary.Game
{
    public  class Game : Scene
    {
        /// <summary>
        /// Статическая ссылка на класс
        /// </summary>
        public static Game instanse = null;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Game()
        {
            if (instanse == null)
                instanse = this;

            var gameConstructor = new GameObjectConstructor();

         


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
