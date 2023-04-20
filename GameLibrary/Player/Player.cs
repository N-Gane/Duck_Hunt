using GameEngine;
using GameLibrary.Bullet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Player
{   
    /// <summary>
    /// Класс игрока
    /// </summary>
    public class Player : GameObject
    {
        /// <summary>
        /// Свойство, обозначающее номер игрока
        /// </summary>
        public bool isFirstPlayer { get; private set; }

        /// <summary>
        /// Свойство ящика с различными видами пуль
        /// </summary>
        public BulletBox BulletBox { get; private set; }

        /// <summary>
        /// Свойство для  подсчёта очков первого игрока
        /// </summary>
        public static int FirstPlayerScore {get; private set;}

        /// <summary>
        /// Свойство для  подсчёта очков второго игрока
        /// </summary>
        public static int SecondPlayerScore { get; private set; }


        /// <summary>
        /// Конструктор объекта класса
        /// </summary>
        public Player(bool firstPlayer) : base()
        {
            BulletBox = new BulletBox();
            BulletBox.Add(new StandartBullet(1, 50));

            this.isFirstPlayer = firstPlayer;
        }

        /// <summary>
        /// Изменение очков игрока
        /// </summary>
        /// <param name="firstPlayer"></param>
        /// <param name="score">Количество очков</param>
        public static void AddScore(bool firstPlayer, int score)
        {
            if (firstPlayer)
                FirstPlayerScore += score;
            else
                SecondPlayerScore += score;
        }

        /// <summary>
        /// Метод обновления кадров
        /// </summary>
        public override void Update()
        {
           
        }

    }
}
