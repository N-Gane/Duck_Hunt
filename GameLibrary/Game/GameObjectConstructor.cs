using GameEngine;
using GameLibrary.Scripts;
using OpenTK;


namespace GameLibrary.Game
{
    /// <summary>
    /// Класс конструктор игровых объектов
    /// </summary>
    public class GameObjectConstructor
    {
        /// <summary>
        /// Инициализация игрока
        /// </summary>
        /// <param name="firstPlayer"></param>
        /// <param name="position"></param>
        /// <returns>Игровой объект типа "Игрок"</returns>
        public GameObject CreatePlayer( bool firstPlayer, Vector2 position)
        {
            Player.Player gameObject = new Player.Player(firstPlayer);

            TextureBox texturePlayer1;

            if (firstPlayer)
                texturePlayer1 = new TextureBox(ContentPipe.LoadTexture("Scope1.png"));
            else
                texturePlayer1 = new TextureBox(ContentPipe.LoadTexture("Scope2.png"));

            gameObject.SetComponent(texturePlayer1);

            var playerScript1 = new PlayerBehavior();
            playerScript1.Start(gameObject);

            var colliderComponent1 = new ColliderComponents(0.3f, new Vector2(2, 20));
            colliderComponent1.SetGameObject(gameObject);

            var systemCollider = new SystemCollider();
            systemCollider.Add(colliderComponent1, "first");

            gameObject.SetComponent(systemCollider);
            gameObject.SetComponent(new Position(position, new Vector2(0.5f, 0.5f)));
            gameObject.SetComponent(playerScript1);


            return gameObject;
        }


        //public GameObject CreateCloud(Vector2 position)
        //{
            


        //}


        //public GameObject CreateGround(Vector2 position)
        //{

        //}

    }
}
