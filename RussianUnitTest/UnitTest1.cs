using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RussianUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Russianbullet.RBclass game = new Russianbullet.RBclass();
        
        [TestMethod]
        public void TestMethod1()
        {
            int result = game.ShootingAway();

            Assert.IsTrue(result < 3);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int result = game.Fire();

            Assert.IsTrue(result < 5);

        }
    }
}
