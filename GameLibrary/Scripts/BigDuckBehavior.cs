using GameEngine;
using OpenTK;
using System;


namespace GameLibrary.Scripts
{
    internal class BigDuckBehavior : DuckBehavior
    {
        float curSpeed;

        double interval;

        Random random;

        float timer;

        int height;
        int widch;

        Game.Game game;

        /// <summary>
        /// Инициализация скрипта
        /// </summary>
        public override void Start(GameObject gameObject = null)
        {
            random = new Random();

            interval = random.NextDouble();

            game = Game.Game.instance;

            if (game != null)
            {
                height = game.HeightOfApplication;
                widch = game.WidthOfApplication;
            }

            if (gameObject != null)
                curSpeed = (gameObject as Duck.Duck).Speed;
        }

        /// <summary>
        /// Обновление скрипта
        /// </summary>
        public override void Update(GameObject gameObject)
        {
            timer += Time.DeltaTime;

            if (timer >= interval)
            {
                timer = 0;
                interval = random.NextDouble();

                curSpeed = (gameObject as Duck.Duck).Speed;
            }

            curSpeed = (gameObject as Duck.Duck).Speed - (gameObject as Duck.Duck).Speed * (timer / (float)interval);


            if (gameObject != null)
            {
                if (gameObject.Position.Location.Y >= height / 1.5f)
                {
                    gameObject.Collider.DeleteGameObject(gameObject);
                    game.AddObjectsToRemove(gameObject);
                }

                gameObject.Position.Location += new Vector2(0, Time.DeltaTime) * curSpeed;
                //gameObject.Transform.Position = new Vector2(0, 0);

                if ((timer / (float)interval) >= 0.5f)
                    gameObject.Texture.Set("Up");
                else
                    gameObject.Texture.Set("Down");
            }
        }
    }
}
