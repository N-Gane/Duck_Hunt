using GameLibrary;
using GameLibrary.Bullet;

using System;

namespace UnitTestGame
{
    [Fact]
    public class BulletDecoratorTest
    {
        StandartBullet bullet;

        [TestInitialize]
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
