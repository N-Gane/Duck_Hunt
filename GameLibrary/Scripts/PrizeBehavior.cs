using GameEngine;
using OpenTK;


namespace GameLibrary.Scripts
{
    internal class PrizeBehavior : ObjectScript
    {

        Game.Game game;

        /// <summary>
        /// Инициализация скрипта
        /// </summary>
        public override void Start(GameObject gameObject = null)
        {
            game = Game.Game.instance;
        }

        /// <summary>
        /// Обновление скрипта
        /// </summary>
        public override void Update(GameObject gameObject)
        {
            gameObject.Position.Location += new Vector2(0, -Time.DeltaTime * 150);

            if (gameObject.Position.Location.Y < -360)
            {
                gameObject.Collider.DeleteGameObject(gameObject);
                game.AddObjectsToRemove(gameObject);
            }
        }

        /// <summary>
        /// Взаимодействие скрипта с игровым объектом
        /// </summary>
        public void Action(GameObject gameObject, Player.Player player)
        {
            (gameObject as Prize.Prize).Action(player);

            gameObject.Collider.DeleteGameObject(gameObject);
            game.AddObjectsToRemove(gameObject);
        }
    }
}
