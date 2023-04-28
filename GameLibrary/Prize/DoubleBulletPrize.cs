using GameLibrary.Bullet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Prize
{
    /// <summary>
    /// Класс приза с патронами
    /// </summary>
    internal class DoubleBulletPrize : Prize
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public DoubleBulletPrize() : base()
        {

        }

        /// <summary>
        /// Декорация игрока
        /// </summary>
        public override void Action(Player.Player player)
        {
            player.BulletBox.Add(new DoubleBulletDecorator(new StandartBullet(1, 5)));
        }
    }
}
