
namespace GameEngine
{
    /// <summary>
    /// Класс, хранящий текстуры
    /// </summary>
    public class Texture2D
    {
        /// <summary>
        /// Конструктор для создания объекта класса
        /// </summary>
        /// <param name="id"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Texture2D(int id, int width, int height)
        {
            this._id = id;
            this._width = width;
            this._height = height;
        }

        private int _id;
        private int _width, _height;

        /// <summary>
        /// Свойство для хранения id текстуры
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Свойство для хранения ширины текстуры
        /// </summary>
        public int Width
        {
            get { return _width; }
        }

        /// <summary>
        /// Свойство для хранения высоты текстуры
        /// </summary>
        public int Height
        {
            get { return _height; }
        }
    }
}
