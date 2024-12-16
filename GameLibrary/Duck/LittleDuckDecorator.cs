namespace GameLibrary.Duck
{
    public class LittleDuckDecorator : DuckDecorator
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="duck"></param>
        public LittleDuckDecorator(Duck duck) : base(duck)
        {
        }

        /// <summary>
        /// Скорость
        /// </summary>
        public override float Speed { get => duck.Speed * 2; }

        /// <summary>
        /// Здоровье
        /// </summary>
        public override float HP { get => duck.HP / 2; }

        /// <summary>
        /// Изменение количества здоровья
        /// </summary>
        /// <param name="value">пункты здоровье</param>
        public override void SetHP(float value)
        {
            duck.SetHP(value * 2);
        }
    }
}