using GameEngine;
using OpenTK;


namespace GameLibrary.Scripts
{
    internal class ScriptCloud : ObjectScript
    {
        float vel = -1;

        /// <summary>
        /// Инициализация скрипта
        /// </summary>
        public override void Start(GameObject gameObject = null) { }

        /// <summary>
        /// Обновление скрипта
        /// </summary>
        public override void Update(GameObject gameObject)
        {
            if (gameObject.Position.Location.X < -640)
                gameObject.Position.Location = new Vector2(850, gameObject.Position.Location.Y);

            gameObject.Position.Location += new Vector2(Time.DeltaTime * vel, 0) * 50;
        }

    }
}
