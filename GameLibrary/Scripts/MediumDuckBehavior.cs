using System;

using GameEngine;

using OpenTK;

namespace GameLibrary.Scripts
{
    internal class MediumDuckBehavior : DuckBehavior
    {
        private float vel;

        private Random random;

        private int height;
        private int widch;

        private float timer = 0;
        private float timerWings;

        private float coeffHeight = 0.5f;
        private float coeffSpeed = 5;

        private Game.Game game;

        private bool wingsDown = false;

        /// <summary>
        /// Инициализация скрипта
        /// </summary>
        public override void Start(GameObject gameObject = null)
        {
            random = new Random();

            game = Game.Game.instance;

            if (game != null)
            {
                height = game.HeightOfApplication;
                widch = game.WidthOfApplication;
            }

            if (random.Next(0, 2) == 0)
                vel = -1;
            else
                vel = 1;

            if (gameObject != null)
            {
                if (vel == -1)
                    gameObject.Position.Location = new Vector2(widch / 1.5f, random.Next(-200, 201));
                else
                    gameObject.Position.Location = new Vector2(-1 * widch / 1.5f, random.Next(-200, 201));
            }
        }

        /// <summary>
        /// Обновление скрипта
        /// </summary>
        public override void Update(GameObject gameObject)
        {
            timer += Time.DeltaTime;

            gameObject.Position.SetMovement(new Vector2(vel, (float)Math.Sin(timer * coeffSpeed) / coeffHeight) * (gameObject as Duck.Duck).Speed * Time.DeltaTime);

            timerWings += Time.DeltaTime;

            if (timerWings >= 0.7f)
            {
                timerWings = 0;

                if (wingsDown)
                    wingsDown = false;
                else
                    wingsDown = true;
            }

            if (vel == 1)
            {
                if (wingsDown)
                    gameObject.Texture.Set("LeftDown");
                else
                    gameObject.Texture.Set("Left");
            }
            else
            {
                if (wingsDown)
                    gameObject.Texture.Set("RightDown");
                else
                    gameObject.Texture.Set("Right");
            }

            if (vel == -1)
            {
                if (gameObject.Position.Location.X < vel * widch / 2)
                {
                    gameObject.Collider.DeleteGameObject(gameObject);
                    game.AddObjectsToRemove(gameObject);
                }
            }
            else if (vel == 1)
            {
                if (gameObject.Position.Location.X > vel * widch / 2)
                {
                    gameObject.Collider.DeleteGameObject(gameObject);
                    game.AddObjectsToRemove(gameObject);
                }
            }
        }
    }
}