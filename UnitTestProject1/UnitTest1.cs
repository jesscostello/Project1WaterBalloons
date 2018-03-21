using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1WaterBalloons;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Form3 f3 = new Form3();
        RandomBalloonNumber myNumber = new RandomBalloonNumber();
        BalloonCounter myBalloonCounter = new BalloonCounter();

        [TestMethod]
        public void TestRandomNumber()
        {
            int RdmNum = myNumber.GetRandom();

            Assert.IsTrue(RdmNum >0 && RdmNum <7);
        }

        [TestMethod]
        public void TestBalloonCountDown()
        {
            int Counter = myBalloonCounter.DecreaseCounterValue();

            Assert.AreEqual(5, Counter);
        }

        
    }
}
