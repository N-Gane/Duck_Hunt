using GameEngine;
using GameLibrary.Factory;
using OpenTK;


namespace GameLibrary.PresentsLauncher
{
    /// <summary>
    /// Класс,объекты которго отрисовываются на игровом поле в качестве призов
    /// </summary>
    public class PresentsLauncherPrize : PresentsLauncher
    {
        public PresentsLauncherPrize() : base()
        {
            factory = new FactoryPrize();
        }

        /// <summary>
        /// Обновление и модификация кадров, применение метода рандомной гнерации призов из класса Factory
        /// </summary>
        public override void Update()
        {
            timer += Time.DeltaTime;

            if (timer >= delay)
            {
                timer = 0;
                delay = random.Next(5, 10);
                game.AddObjectsToAdd(factory.GetRandomGameObject(new Vector2(0.15f, 0.15f), new Vector2(random.Next(-600, 601), 360)));
            }
        }
    }
}
