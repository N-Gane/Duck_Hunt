
namespace GameLibrary.Bullet
{
    public abstract class Bullet
    {
        /// <summary>
        /// Сила пули
        /// </summary>
        public abstract float Power { get; }

        /// <summary>
        /// Количество пуль
        /// </summary>
        public abstract int Count { get; }


        protected float currPower;
        protected int currCount;

        /// <summary>
        /// Изменение количества пуль
        /// </summary>
        /// <param name="count"></param>
        public virtual void Add(int count)
        {
            currCount += count;
        }

        /// <summary>
        /// Метод,характеризующий выстрел
        /// </summary>
        /// <returns>True, если выстрел возможен</returns>
        public virtual bool Shot()
        {
            if (currCount > 0)
            {
                currCount--;
                return true;
            }

            return false;
        }

    }
}
