using OpenTK;

namespace GameEngine
{
    public class Position
    {
        /// <summary>
        /// Конструктор компонента
        /// </summary>
        /// <param name="location">Начальная позиция</param>
        /// <param name="scale">Начальный размер</param>
        public Position(Vector2 location, Vector2 scale)
        {
            Location = location;
            Scale = scale;
        }

        /// <summary>
        /// Позиция игрового объекта
        /// </summary>
        public Vector2 Location { get; set; }

        /// <summary>
        /// Размер игрового объекта
        /// </summary>
        public Vector2 Scale { get; set; }

        /// <summary>
        /// Перемещение объекта
        /// </summary>
        /// <param name="movement">Вектор перемещения</param>
        public void SetMovement(Vector2 movement)
        {
            Location += movement;
        }
    }
}