

namespace GameLibrary.Duck
{
    internal class MediumDuck : Duck
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="speed">Пункты скорости</param>
        /// <param name="hp">Пункты здоровья</param>
        public MediumDuck(float speed, float hp)
        {
            currSpeed = speed;
            currHP = hp;
        }

        /// <summary>
        /// Пункты скорости
        /// </summary>
        public override float Speed { get => currSpeed; }

        /// <summary>
        /// Пункты здоровья
        /// </summary>
        public override float HP { get => currHP; }
    }
}
