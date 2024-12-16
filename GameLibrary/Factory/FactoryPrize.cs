using GameEngine;

using GameLibrary.Prize;
using GameLibrary.Scripts;

using OpenTK;

namespace GameLibrary.Factory
{
    /// <summary>
    /// Kласс характерезующий фабрику призов
    /// </summary>
    public class FactoryPrize : Factory
    {
        private Prize.Prize prize;

        /// <summary>
        /// Метод реализующий гибкую генерацию призов случайных типов
        /// </summary>
        /// <param name="position">Позиция спавна</param>
        /// <returns>Игровой объект характерезующий приз</returns>
        public override GameObject GetRandomGameObject(Vector2 scale, Vector2 position)
        {
            switch (random.Next(1, 3))
            {
                case 1:
                    prize = new DoubleBulletPrize();
                    var colliderComponent11 = new ColliderComponents();
                    colliderComponent11.SetGameObject(prize);

                    var prizeScript1 = new PrizeBehavior();
                    prizeScript1.Start(prize);

                    var systemCollider1 = new SystemCollider();
                    systemCollider1.Add(colliderComponent11, "first");

                    prize.SetComponent(systemCollider1);
                    prize.SetComponent(new TextureBox(ContentPipe.LoadTexture("DoubleBulletPrize.png")));
                    prize.SetComponent(new Position(position, scale));
                    prize.SetComponent(prizeScript1);
                    return prize;

                case 2:
                    prize = new BulletPrize();
                    var colliderComponent21 = new ColliderComponents();
                    colliderComponent21.SetGameObject(prize);

                    var prizeScript2 = new PrizeBehavior();
                    prizeScript2.Start(prize);

                    var systemCollider2 = new SystemCollider();
                    systemCollider2.Add(colliderComponent21, "first");

                    prize.SetComponent(systemCollider2);
                    prize.SetComponent(new TextureBox(ContentPipe.LoadTexture("BulletPrize.png")));
                    prize.SetComponent(new Position(position, scale));
                    prize.SetComponent(prizeScript2);
                    return prize;
            }
            return null;
        }
    }
}