

namespace GameLibrary.Bullet
{
    public class BulletDecorator : Bullet
    {
        /// <summary>
        /// Декорируемая пуля
        /// </summary>
        protected Bullet bullet;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="bullet"></param>
        public BulletDecorator(Bullet bullet)
        {
            this.bullet = bullet;
        }

        /// <summary>
        /// Сила пули
        /// </summary>
        public override float Power { get => bullet.Power; }

        /// <summary>
        /// Количество пуль
        /// </summary>
        public override int Count { get => bullet.Count; }

        /// <summary>
        /// Добавление новых пуль
        /// </summary>
        /// <param name="count"></param>
        public override void Add(int count)
        {
            bullet.Add(count);
        }

        /// <summary>
        /// Метод, характерезующий выстрел
        /// </summary>
        /// <returns>True - если выстрел возможен</returns>
        public override bool Shot()
        {
            return bullet.Shot();
        }
    }
}
