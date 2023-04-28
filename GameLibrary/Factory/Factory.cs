using GameEngine;
using OpenTK;
using System;


namespace GameLibrary.Factory
{
    /// <summary>
    /// Абстрактныйкласс характерезующий Фабрику игровых объектов
    /// </summary>
    public abstract class Factory
    {
        protected Random random = new Random();

        /// <summary>
        /// Метод реализующий гибкую генерацию призов случайных типов
        /// </summary>
        /// <param name="position">позития спавна</param>
        /// <returns>Игровой объект</returns>
        public abstract GameObject GetRandomGameObject(Vector2 scale, Vector2 position);
    }
}
