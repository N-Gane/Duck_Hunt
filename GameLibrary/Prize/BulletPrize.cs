using GameLibrary.Bullet;

namespace GameLibrary.Prize
{
    /// <summary>
    /// Класс приза с патронами
    /// </summary>
    public class BulletPrize : Prize
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public BulletPrize() : base()
        {
        }

        /// <summary>
        /// Декорация игрока
        /// </summary>
        public override void Action(Player.Player player)
        {
            player.BulletBox.Add(new StandartBullet(1, 20));
        }
    }
}