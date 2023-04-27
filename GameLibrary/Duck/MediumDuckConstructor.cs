using GameEngine;
using GameLibrary.Scripts;
using OpenTK;


namespace GameLibrary.Duck
{
    /// <summary>
    /// Класс, характерезующий конструктор средней утки
    /// </summary>
    internal class MediumDuckConstructor : DuckConstructor
    {
        /// <summary>
        /// Инициализация утки
        /// </summary>
        public override Duck CreateDuck()
        {
            duck = new MediumDuck(250, 2);

            textureDuck = new TextureBox(ContentPipe.LoadTexture("DuckRight.png"));
            textureDuck.Add("Right", ContentPipe.LoadTexture("DuckRight.png"));
            textureDuck.Add("Left", ContentPipe.LoadTexture("DuckLeft.png"));
            textureDuck.Add("RightDown", ContentPipe.LoadTexture("DuckRightDown.png"));
            textureDuck.Add("LeftDown", ContentPipe.LoadTexture("DuckLeftDown.png"));
            textureDuck.Add("Tuch", ContentPipe.LoadTexture("DuckTuch.png"));

            duck.SetComponent(textureDuck);

            colliderComponents1 = new ColliderComponents(0.3f, new Vector2(30, 20));
            colliderComponents1.SetGameObject(duck);

            colliderComponents2 = new ColliderComponents();
            colliderComponents2.SetGameObject(duck);

            collider = new SystemCollider();
            collider.Add(colliderComponents1, "first");
            collider.Add(colliderComponents2, "second");

            duck.SetComponent(collider);
            duck.SetComponent(new Position(new Vector2(random.Next(-600, 601), -360), new Vector2(0.1f, 0.1f)));

            script = new MediumDuckBehavior();
            script.Start(duck);

            duck.SetComponent(script);

            return duck;
        }

    }
}
