using GameEngine;

using GameLibrary.Duck;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenTK;

namespace UnitTestGame
{
    [TestClass]
    public class ColliderTest
    {
        /// <summary>
        /// Тестирование коллизий
        /// </summary>
        [TestMethod]
        public void TestCollider()
        {
            var firstObject = new MediumDuck(10, 2);
            firstObject.SetComponent(new Position(new Vector2(1f, 1f), new Vector2(1, 1)));

            var firstCollider = new ColliderComponents();
            firstCollider.SetGameObject(firstObject);

            var firstSystemCollider = new SystemCollider();
            firstSystemCollider.Add(firstCollider, "first");

            firstObject.SetComponent(firstSystemCollider);

            var secondObject = new MediumDuck(10, 2);
            secondObject.SetComponent(new Position(new Vector2(1f, 3f), new Vector2(1, 1)));

            var secondCollider = new ColliderComponents();
            secondCollider.SetGameObject(secondObject);

            var secondSystemCollider = new SystemCollider();
            secondSystemCollider.Add(secondCollider, "first");

            secondObject.SetComponent(secondSystemCollider);

            Assert.IsFalse(firstObject.Collider.CheckGameObjectIntersection(secondObject));

            secondObject.Position.Location = new Vector2(1f, 1f);

            Assert.IsTrue(firstObject.Collider.CheckGameObjectIntersection(secondObject));
        }
    }
}