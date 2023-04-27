using GameEngine;
using OpenTK;
using System;


namespace GameLibrary.Scripts
{
    public class LittleDuckBehavior : DuckBehavior
    {
        float vel = 1;
        float dir = 1;

        float curVel;
        float curDir;

        double interval;

        Random random;

        float timer;
        float timerWings;

        int height;
        int widch;

        Game.Game game;

        bool wingsDown = false;

        /// <summary>
        /// Инициализация скрипта
        /// </summary>
        public override void Start(GameObject gameObject = null)
        {
            random = new Random();

            interval = random.NextDouble();

            game = Game.Game.instanse;

            if (game != null)
            {
                height = game.HeightOfApplication;
                widch = game.WidthOfApplication;
            }
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

                curVel = vel;
                curDir = dir;

                do
                {
                    dir = random.Next(-1, 2);
                }
                while (dir == 0);

                do
                {
                    vel = random.Next(-1, 2);
                }
                while ((dir != curDir) && (vel != curVel) || vel == 0);
            }

            if (gameObject != null)
            {
                if (gameObject.Position.Location.X <= -widch / 2)
                {
                    vel = 1;
                }
                else if (gameObject.Position.Location.X >= widch / 2)
                {
                    vel = -1;
                }

                if (gameObject.Position.Location.Y <= -height / 2)
                {
                    dir = 1;
                }
                else if (gameObject.Position.Location.Y >= height / 1.5f)
                {
                    gameObject.Collider.DeleteGameObject(gameObject);
                    game.AddObjectsToRemove(gameObject);
                }

                gameObject.Position.Location += new Vector2(Time.DeltaTime * vel, Time.DeltaTime * dir) * (gameObject as Duck.Duck).Speed;

                timerWings += Time.DeltaTime;

                if (timerWings >= 0.25f)
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
            }
        }
    }
}
