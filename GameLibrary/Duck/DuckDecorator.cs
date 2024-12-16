using GameEngine;

namespace GameLibrary.Duck
{
    public class DuckDecorator : Duck
    {
        /// <summary>
        /// Декорируемая утка
        /// </summary>
        protected Duck duck;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="duck"></param>
        public DuckDecorator(Duck duck)
        {
            this.duck = duck;
        }

        /// <summary>
        /// Скорость
        /// </summary>
        public override float Speed => duck.Speed;

        /// <summary>
        /// Здоровье
        /// </summary>
        public override float HP => duck.HP;

        /// <summary>
        /// Свойство, хранящее текстуру объекта
        /// </summary>
        public override TextureBox Texture { get => duck.Texture; }

        /// <summary>
        /// Класс, хранящее позицию объекта
        /// </summary>
        public override Position Position { get => duck.Position; }

        /// <summary>
        /// Сценарий выполения
        /// </summary>
        public override ObjectScript Script { get => duck.Script; }

        /// <summary>
        /// Твёрдое тело
        /// </summary>
        public override SystemCollider Collider { get => duck.Collider; }

        /// <summary>
        /// Изменение количества здоровья
        /// </summary>
        /// <param name="value"></param>
        public override void SetHP(float value)
        {
            duck.SetHP(value);
        }

        /// <summary>
        /// Установка компонентов
        /// </summary>
        /// <param name="component"></param>
        public override void SetComponent(object component)
        {
            duck.SetComponent(component);
        }

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        public override void Dispose()
        {
            duck.Dispose();
        }
    }
}