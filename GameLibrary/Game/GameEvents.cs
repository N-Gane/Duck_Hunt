namespace GameLibrary.Game
{
    /// <summary>
    /// Статический класс событий игры
    /// </summary>
    public static class GameEvents
    {
        /// <summary>
        /// Делегат события изменения количества пуль
        /// </summary>
        /// <param name="firstPlayer">Тэг игрового объекта игрока</param>
        /// <param name="Value">Значение собранных очков</param>
        public delegate void BulletCountDelegate(bool firstPlayer, int Value);

        /// <summary>
        /// Событие изменения количества пуль
        /// </summary>
        public static BulletCountDelegate ChangeBulletCount { get; set; }

        /// <summary>
        /// Делегат события окончания игры
        /// </summary>
        /// <param name="winPlayer"></param>
        public delegate void EndGameDelegate(bool? winPlayer = null);

        /// <summary>
        /// Событие окончания игры
        /// </summary>
        public static EndGameDelegate EndGame { get; set; }

        /// <summary>
        /// Делегат события изменения типа пуль
        /// </summary>
        /// <param name="firstPlayer">Тег игрового объекта игрока</param>
        /// <param name="value">Название эффекта</param>
        public delegate void TypeBulletDelegate(bool firstPlayer, string value);

        /// <summary>
        /// Событие изменения пуль
        /// </summary>
        public static TypeBulletDelegate ChangeTypeBullet { get; set; }

        /// <summary>
        /// Делегат события изменения количества сбитых уток
        /// </summary>
        /// <param name="firstPlayer">Тег игрового объекта игрока</param>
        /// <param name="value">Название оружия</param>
        public delegate void CountDuckDelegate(bool firstPlayer, int value);

        /// <summary>
        /// Событие изменения количества сбитых уток
        /// </summary>
        public static CountDuckDelegate ChangeCountDuck { get; set; }
    }
}