using GameEngine;
using GameLibrary.Scripts;
using OpenTK;


namespace GameLibrary.Duck
{
    /// <summary>
    /// Класс, характерезующий конструктор маленькой утки
    /// </summary>
    public class LittleDuckConstructor : DuckConstructor
    {
        /// <summary>
        /// Инициализация утки
        /// </summary>
        public override Duck CreateDuck()
        {
            duck = new LittleDuckDecorator(new MediumDuck(150, 2));

            textureDuck = new TextureBox(ContentPipe.LoadTexture("LittleDuckRight.png"));
            textureDuck.Add("Right", ContentPipe.LoadTexture("LittleDuckRight.png"));
            textureDuck.Add("Left", ContentPipe.LoadTexture("LittleDuckLeft.png"));
            textureDuck.Add("RightDown", ContentPipe.LoadTexture("LittleDuckRightDown.png"));
            textureDuck.Add("LeftDown", ContentPipe.LoadTexture("LittleDuckLeftDown.png"));
            textureDuck.Add("Tuch", ContentPipe.LoadTexture("LittleDuckTuch.png"));

            duck.SetComponent(textureDuck);

            script = new LittleDuckBehavior();
            script.Start(duck);

            colliderComponents1 = new ColliderComponents();
            colliderComponents1.SetGameObject(duck);

            colliderComponents2 = new ColliderComponents();
            colliderComponents2.SetGameObject(duck);

            collider = new SystemCollider();
            collider.Add(colliderComponents1, "first");
            collider.Add(colliderComponents2, "second");

            duck.SetComponent(textureDuck);
            duck.SetComponent(collider);
            duck.SetComponent(new Position(new Vector2(random.Next(-600, 601), -320), new Vector2(0.091f, 0.091f)));
            duck.SetComponent(script);

            return duck;
        }
    }
}
