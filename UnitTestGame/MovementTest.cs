using GameEngine;

using GameLibrary.Duck;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenTK;

namespace UnitTestGame
{
    [TestClass]
    public class MovementTest
    {
        /// <summary>
        /// Тестирование движений игровых объектов
        /// </summary>
        [TestMethod]
        public void TestGameObjectMovement()
        {
            var gameObject = new MediumDuck(10, 2);
            gameObject.SetComponent(new Position(new Vector2(0f, 0f), new Vector2(1, 1)));

            Vector2 offset = new Vector2(1f, 1f);

            gameObject.Position.SetMovement(offset);

            Vector2 expected = new Vector2(1f, 1f);
            Vector2 actual = gameObject.Position.Location;

            Assert.AreEqual(expected, actual);
        }
    }
}