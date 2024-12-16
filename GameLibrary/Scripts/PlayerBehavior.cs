using GameEngine;

using OpenTK;
using OpenTK.Input;

using static GameEngine.InputAxis;

namespace GameLibrary.Scripts
{
    public class PlayerBehavior : ObjectScript
    {
        public bool IsShot { get; set; }

        private bool IsNotShot;
        private bool IsSwitch;

        public float Speed { get; private set; }

        public Vector2 direction = new Vector2();

        public PlayerControl Control { get; private set; }

        public override void Start(GameObject gameObject = null)
        {
            Speed = 500;

            IsNotShot = true;
            IsSwitch = false;

            if ((gameObject as Player.Player).isFirstPlayer)
                Control = new PlayerControl(AxisOfInput.Horizontal, AxisOfInput.Vertical, Key.E, Key.Q);
            else
                Control = new PlayerControl(AxisOfInput.AlternativeHorizontal, AxisOfInput.AlternativeVertical, Key.ShiftRight, Key.ControlRight);
        }

        public override void Update(GameObject gameObject)
        {
            if (IsShot)
                IsShot = false;

            UpdateKeys(gameObject);

            gameObject.Position.SetMovement(direction * Speed * Time.DeltaTime);

            DetectCollision(gameObject);
        }

        public void UpdateKeys(GameObject gameObject)
        {
            direction = new Vector2(InputAxis.GetAxis(Control.HorizontalAxis), InputAxis.GetAxis(Control.VerticalAxis));

            if (gameObject.Position.Location.X > 660 && direction.X == 1)
                direction.X = 0;

            if (gameObject.Position.Location.X < -660 && direction.X == -1)
                direction.X = 0;

            if (gameObject.Position.Location.Y > 400 && direction.Y == 1)
                direction.Y = 0;

            if (gameObject.Position.Location.Y < -340 && direction.Y == -1)
                direction.Y = 0;

            if (InputAxis.GetButtonDown(Control.GetSwitch) && !IsSwitch)
            {
                (gameObject as Player.Player).BulletBox.Switch();
                IsSwitch = true;
            }

            if (InputAxis.GetButtonDown(Control.GetSwitch))
                IsSwitch = false;

            if (InputAxis.GetButtonDown(Control.ShootKey) && IsNotShot)
            {
                IsShot = (gameObject as Player.Player).BulletBox.Bullet.Shot();
                IsNotShot = false;
            }

            if (!InputAxis.GetButtonDown(Control.ShootKey))
                IsNotShot = true;
        }

        private void DetectCollision(GameObject gameObject)
        {
            if (IsShot && gameObject.Collider.CheckGameObjectIntersection(out GameObject otherGameObject))
            {
                if (otherGameObject is Duck.Duck && otherGameObject.Script != null)
                {
                    var script = otherGameObject.Script;
                    if (script is DuckBehavior)
                    {
                        (script as DuckBehavior).Action(otherGameObject, gameObject as Player.Player);
                    }
                }

                if (otherGameObject is Prize.Prize && otherGameObject.Script != null)
                {
                    var script = otherGameObject.Script;
                    if (script is PrizeBehavior)
                    {
                        (script as PrizeBehavior).Action(otherGameObject, gameObject as Player.Player);
                    }
                }
            }
        }

        public struct PlayerControl
        {
            public AxisOfInput HorizontalAxis { get; private set; }

            public AxisOfInput VerticalAxis { get; private set; }

            public Key ShootKey { get; private set; }

            public Key GetSwitch { get; private set; }

            public PlayerControl(AxisOfInput horizontalAxis, AxisOfInput verticalAxis, Key shootKey, Key getSwitch)
            {
                HorizontalAxis = horizontalAxis;
                VerticalAxis = verticalAxis;
                ShootKey = shootKey;
                GetSwitch = getSwitch;
            }
        }
    }
}