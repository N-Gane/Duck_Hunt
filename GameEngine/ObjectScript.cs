
namespace GameEngine
{
    /// <summary>
    /// Абстрактный класс, описывающий сценарий поведения игрового объекта
    /// </summary>
    public abstract class ObjectScript
    {
        /// <summary>
        /// Поведение в момент создания игрового объекта
        /// </summary>
        /// <param name="gameObject"></param>
        public abstract void Start(GameObject gameObject = null);

        /// <summary>
        /// Обновление игрового процесса
        /// </summary>
        /// <param name="gameObject"></param>
        public abstract void Update(GameObject gameObject);
    }
}
