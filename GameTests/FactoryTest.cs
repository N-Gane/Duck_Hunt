using GameLibrary.Duck;
using GameLibrary.Factory;
using GameLibrary.Prize;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenTK;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace GameTests
{
    [TestClass]
    public class FactoryTest : GameWindow
    {
        /// <summary>
        /// Тест фабрики уток
        /// </summary>
        [TestMethod]
        public void TestMethodFactoryDuck()
        {
            var factory = new FactoryDuck();

            var duck = factory.GetRandomGameObject(new Vector2(1, 1), new Vector2(1, 1));
            Assert.IsTrue(duck is Duck);
        }

        /// <summary>
        /// Тест фабрики уток
        /// </summary>
        [TestMethod]
        public void TestMethodFactoryPrize()
        {
            var factory = new FactoryPrize();

            var duck = factory.GetRandomGameObject(new Vector2(1, 1), new Vector2(1, 1));
            Assert.IsTrue(duck is Prize);
        }
    }
}
