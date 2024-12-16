using GameEngine;

using GameLibrary.Duck;

using OpenTK;

namespace GameLibrary.Factory
{
    /// <summary>
    /// Kласс характерезующий фабрику уток
    /// </summary>
    public class FactoryDuck : Factory
    {
        private MediumDuckConstructor mediumDuck;
        private LittleDuckConstructor littleDuck;
        private BigDuckConstructor bigDuck;

        public FactoryDuck()
        {
            mediumDuck = new MediumDuckConstructor();
            littleDuck = new LittleDuckConstructor();
            bigDuck = new BigDuckConstructor();
        }

        /// <summary>
        /// Метод реализующий гибкую генерацию призов случайных типов
        /// </summary>
        /// <param name="position">Позиция спавна</param>
        /// <returns>Игровой объект характерезующий утку</returns>
        public override GameObject GetRandomGameObject(Vector2 scale, Vector2 position)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    return mediumDuck.CreateDuck();

                case 2:
                    return littleDuck.CreateDuck();

                case 3:
                    return bigDuck.CreateDuck();
            }
            return null;
        }
    }
}