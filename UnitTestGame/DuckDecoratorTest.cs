using GameLibrary.Duck;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGame
{
    [TestClass]
    public class DuckDecoratorTest
    {
        private MediumDuck duck;

        [TestInitialize]
        public void InitalizeDuck()
        {
            duck = new MediumDuck(10, 2);
        }

        /// <summary>
        /// Тестирование декорации большой утки
        /// </summary>
        [TestMethod]
        public void BigDuckDecoratorTest()
        {
            var bigDuck = new BigDuckDecorator(duck);

            float expectedHP = duck.HP * 2;
            float actualHP = bigDuck.HP;

            Assert.AreEqual(expectedHP, actualHP);

            float expectedSpeed = duck.Speed * 2;
            float actualSpeed = bigDuck.Speed;

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }

        /// <summary>
        /// Тестирование декорации маленькой утки
        /// </summary>
        [TestMethod]
        public void LittleDuckDecoratorTest()
        {
            var littleDuck = new LittleDuckDecorator(duck);

            float expectedHP = duck.HP / 2;
            float actualHP = littleDuck.HP;

            Assert.AreEqual(expectedHP, actualHP);

            float expectedSpeed = duck.Speed * 2;
            float actualSpeed = littleDuck.Speed;

            Assert.AreEqual(expectedSpeed, actualSpeed);
        }
    }
}