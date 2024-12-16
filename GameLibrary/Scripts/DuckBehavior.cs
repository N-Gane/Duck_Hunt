using GameEngine;
using GameLibrary.Game;


namespace GameLibrary.Scripts
{
    public abstract class DuckBehavior : ObjectScript
    {
        /// <summary>
        /// Взаимодействие скрипта с игровыми объектами
        /// </summary>
        /// <param name="gameObject"></param>
        /// <param name="player"></param>
        public virtual void Action(GameObject gameObject, Player.Player player)
        {
            int? numbelCollider = gameObject.Collider.GetNumberColliderIntersection(player);

            if (numbelCollider != null)
                if (numbelCollider == 1)
                    (gameObject as Duck.Duck).SetHP(-player.BulletBox.Bullet.Power * 2);
                else
                    (gameObject as Duck.Duck).SetHP(-player.BulletBox.Bullet.Power);

            gameObject.Texture.Set("Tuch", 0.15f);

            if ((gameObject as Duck.Duck).HP <= 0)
            {
                Player.Player.AddScore(player.isFirstPlayer, 1);

                if (player.isFirstPlayer)
                    GameEvents.ChangeCountDuck?.Invoke(player.isFirstPlayer, Player.Player.FirstPlayerScore);
                else
                    GameEvents.ChangeCountDuck?.Invoke(player.isFirstPlayer, Player.Player.SecondPlayerScore);

                var deathScript = new DeathDuckBehavior();
                deathScript.Start(gameObject);

                gameObject.SetComponent(deathScript);
            }
        }

    }
}
