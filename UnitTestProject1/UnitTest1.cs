using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1WaterBalloons;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        RandomBalloonNumber myNumber = new RandomBalloonNumber();
        BalloonCounter myBalloonCounter = new BalloonCounter();
        Result myResult = new Result();

        /// <summary>
        /// Test that the random number generated is between 1 and 6
        /// </summary>
        [TestMethod]
        public void TestRandomNumber()
        {
            int RdmNum = myNumber.GetRandom();

            Assert.IsTrue(RdmNum >0 && RdmNum <7);
        }
        /// <summary>
        /// Test that the counter decreases by 1 
        /// </summary>
        [TestMethod]
        public void TestBalloonCountDown()
        {
            int DecreasedCounter = myBalloonCounter.DecreaseCounterValue();

            Assert.AreEqual(5, DecreasedCounter);
        }
        /// <summary>
        /// Test that the counter is initially set to 6
        /// </summary>
        [TestMethod]
        public void TestCounterAtSix()
        {
            Assert.AreEqual(6, myBalloonCounter.Counter);
        }
        /// <summary>
        /// Test that the winning total increases
        /// </summary>
        [TestMethod]
        public void TestWinResultIncrease()
        {
            int WinTotal = myResult.IncreaseWinTotal();
            Assert.AreEqual(1, WinTotal);
        }
        /// <summary>
        /// Another test to make sure the win result increases (is not 0)
        /// </summary>
        [TestMethod]
        public void TestWinResultChanges()
        {
            int WinTotal = myResult.IncreaseWinTotal();
            Assert.IsFalse(WinTotal == 0);
        }
    }
}