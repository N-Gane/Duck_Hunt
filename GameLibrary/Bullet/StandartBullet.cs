namespace GameLibrary.Bullet
{
    public class StandartBullet : Bullet
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="power"></param>
        /// <param name="count"></param>
        public StandartBullet(float power, int count)
        {
            currPower = power;
            currCount = count;
        }

        /// <summary>
        /// Сила пули
        /// </summary>
        public override float Power => currPower;

        /// <summary>
        /// Количество пуль
        /// </summary>
        public override int Count => currCount;


        public override string ToString()
        {
            return "Standart power";
        }

    }
}
