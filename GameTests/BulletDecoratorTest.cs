using GameLibrary.Bullet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace GameTests
{
    [TestClass]
    public class BulletDecoratorTest
    {
        StandartBullet bullet;

        [Fact]
        public void InitalizeBullet()
        {
            bullet = new StandartBullet(2, 10);
        }

        /// <summary>
        /// Тестирование декоратора пуль
        /// </summary>
        [TestMethod]
        public void DoubleBulletDecoratorTest()
        {
            var doubleBullet = new DoubleBulletDecorator(bullet);

            float expectedPower = bullet.Power * 2;
            float actualPower = doubleBullet.Power;

            Assert.AreEqual(expectedPower, actualPower);
        }
    }
}
