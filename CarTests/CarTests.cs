using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO1: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)


        [TestMethod]
        //public void emptyTest()
        //{
        //    Assert.AreEqual(1, 1, 0.1);
        //}

        //TODO2: constructor sets gasTankLevel properly
        //TODO3: gasTankLevel is accurate after driving within tank range
        public void GasTankLevel()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }

        //TODO4: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void GasTankRange()
        {
            Car test_car = new Car("Ford", "Focus", 14, 34);
            test_car.Drive(500);
            Assert.IsTrue((test_car.GasTankLevel * 34) < 500);
        }


        //TODO5: can't have more gas than tank size, expect an exception

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverFillException()
        {
            Car test_car = new Car("Toyota", "Prius", 10, 50);
            test_car.AddGas(5);
            Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
        }




    }
}
