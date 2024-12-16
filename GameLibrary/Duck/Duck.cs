using GameEngine;

namespace GameLibrary.Duck
{
    public abstract class Duck : GameObject
    {
        /// <summary>
        /// Скорость утки
        /// </summary>
        public abstract float Speed { get; }

        /// <summary>
        /// Здоровье утки
        /// </summary>
        public abstract float HP { get; }

        protected float currHP;
        protected float currSpeed;

        /// <summary>
        /// Изменение количества здоровья
        /// </summary>
        /// <param name="value">Очки здоровья</param>
        public virtual void SetHP(float value)
        {
            currHP += value;
        }

        /// <summary>
        /// Обновление объекта
        /// </summary>
        public override void Update()
        {
            if (Script != null)
                Script.Update(this);
        }
    }
}