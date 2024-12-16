using GameEngine;

using OpenTK;

namespace GameLibrary.Scripts
{
    public class DeathDuckBehavior : ObjectScript
    {
        private Game.Game game;

        /// <summary>
        /// Инициализация скрипта
        /// </summary>
        /// <param name="gameObject"></param>
        public override void Start(GameObject gameObject = null)
        {
            game = Game.Game.instance;
        }

        /// <summary>
        /// Обновление скрипта
        /// </summary>
        /// <param name="gameObject"></param>
        public override void Update(GameObject gameObject)
        {
            gameObject.Position.Location += new Vector2(0, Time.DeltaTime * -500);

            if (gameObject.Position.Location.Y <= -360)
            {
                gameObject.Collider.DeleteGameObject(gameObject);
                game.AddObjectsToRemove(gameObject);
            }
        }
    }
}