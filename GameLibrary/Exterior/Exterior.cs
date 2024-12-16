using GameEngine;

namespace GameLibrary
{
    /// <summary>
    /// Класс, характеризующий декорацию
    /// </summary>
    internal class Exterior : GameObject
    {
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