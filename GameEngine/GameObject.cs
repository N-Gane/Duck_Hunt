using System;

namespace GameEngine
{
    /// <summary>
    /// Класс, представляющий игровой объект.
    /// </summary>
    public abstract class GameObject : IDisposable
    {
        /// <summary>
        /// Свойство, хранящее текстуру объекта
        /// </summary>
        public virtual TextureBox Texture { get; protected set; }

        /// <summary>
        /// Класс, хранящий позициюобъекта
        /// </summary>
        public virtual Position Position { get; protected set; }

        /// <summary>
        /// Сценарий выполнения
        /// </summary>
        public virtual ObjectScript Script { get; protected set; }

        /// <summary>
        /// Класс, описывающий твёрдое тело
        /// </summary>
        public virtual SystemCollider Collider { get; protected set; }

        /// <summary>
        /// Установка игровых объектов
        /// </summary>
        /// <param name="component"></param>
        public virtual void SetComponent(object component)
        {
            switch (component)
            {
                case TextureBox textureBox:
                    Texture = textureBox;
                    break;

                case ObjectScript objectScript:
                    Script = objectScript;
                    break;

                case SystemCollider systemCollider:
                    Collider = systemCollider;
                    break;

                case Position position:
                    Position = position;
                    break;
            }
        }

        /// <summary>
        /// Абстрактный метод для изменения и обновления отрисовки кадров игры
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Метод для освобождения ресурсов
        /// </summary>
        public virtual void Dispose()
        {
            Texture.Dispose();
            Collider.Dispose();
        }
    }
}