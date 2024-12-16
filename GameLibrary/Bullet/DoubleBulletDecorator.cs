namespace GameLibrary.Bullet
{
    public class DoubleBulletDecorator : BulletDecorator
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="bullet"></param>
        public DoubleBulletDecorator(Bullet bullet) : base(bullet)
        {
        }

        /// <summary>
        /// Сила пули
        /// </summary>
        public override float Power { get => bullet.Power * 2; }

        public override string ToString()
        {
            return "Double power";
        }
    }
}