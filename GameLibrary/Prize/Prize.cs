using GameEngine;

namespace GameLibrary.Prize
{
    /// <summary>
    /// Абстрактный класс, характерующий приз
    /// </summary>
    public abstract class Prize : GameObject
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Prize() : base()
        {
        }

        /// <summary>
        /// Обновление приза
        /// </summary>
        public override void Update()
        {
            if (Script != null)
                Script.Update(this);
        }

        /// <summary>
        /// Декорация игрока
        /// </summary>
        public abstract void Action(Player.Player player);
    }
}