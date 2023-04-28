using GameLibrary.Duck;
using GameLibrary.Factory;
using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.PresentsLauncher
{
    /// <summary>
    /// Класс,объекты которго отрисовываются на игровом поле в качестве уток
    /// </summary>
    public class PresentsLauncherDuck : PresentsLauncher
    {
        public PresentsLauncherDuck() : base()
        {
            factory = new FactoryDuck();
        }

        /// <summary>
        /// Обновление и модификация кадров, применение метода рандомной гнерации уток из класса Factory
        /// </summary>
        public override void Update()
        {
            var countDuck = game.CountGameObject(typeof(MediumDuck), typeof(LittleDuckDecorator), typeof(BigDuckDecorator));

            if (countDuck < 4)
            {
                game.AddObjectsToAdd(factory.GetRandomGameObject(new Vector2(1, 1), new Vector2(0, 0)));
            }
        }
    }
}
