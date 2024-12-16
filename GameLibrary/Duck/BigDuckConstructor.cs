using GameEngine;

using GameLibrary.Scripts;

using OpenTK;

namespace GameLibrary.Duck
{
    /// <summary>
    /// Класс, характеризующий конструтор большой утки
    /// </summary>
    internal class BigDuckConstructor : DuckConstructor
    {
        /// <summary>
        /// Инициализация утки
        /// </summary>
        public override Duck CreateDuck()
        {
            duck = new BigDuckDecorator(new MediumDuck(150, 2));

            textureDuck = new TextureBox(ContentPipe.LoadTexture("BigDuckDown.png"));
            textureDuck.Add("Down", ContentPipe.LoadTexture("BigDuckDown.png"));
            textureDuck.Add("Up", ContentPipe.LoadTexture("BigDuckUp.png"));
            textureDuck.Add("Tuch", ContentPipe.LoadTexture("BigDuckTuch.png"));

            duck.SetComponent(textureDuck);

            script = new BigDuckBehavior();
            script.Start(duck);

            colliderComponents1 = new ColliderComponents(0.3f, new Vector2(33, 22));
            colliderComponents1.SetGameObject(duck);

            colliderComponents2 = new ColliderComponents();
            colliderComponents2.SetGameObject(duck);

            collider = new SystemCollider();
            collider.Add(colliderComponents1, "first");
            collider.Add(colliderComponents2, "second");

            duck.SetComponent(textureDuck);
            duck.SetComponent(collider);
            duck.SetComponent(new Position(new Vector2(random.Next(-600, 601), -320), new Vector2(0.11f, 0.11f)));
            duck.SetComponent(script);

            return duck;
        }
    }
}