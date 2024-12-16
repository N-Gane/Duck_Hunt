using System;

using GameEngine;

namespace GameLibrary.PresentsLauncher
{
    /// <summary>
    /// Абстрактный класс, объекты которго отрисовываются на игровом поле
    /// </summary>
    public abstract class PresentsLauncher : GameObject
    {
        protected float timer;
        protected float delay;
        protected Random random = new Random();
        protected Factory.Factory factory;
        protected Game.Game game;

        /// <summary>
        /// Конструктор создания объктов
        /// </summary>
        public PresentsLauncher() : base()
        {
            delay = random.Next(10, 20);
            game = Game.Game.instance;
        }
    }
}