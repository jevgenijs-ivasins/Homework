using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CoffeeMachineLib;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(CoinNotValidException))]
        public void InsertFakeCoin_ResultCoinNotValidException()
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(40);
            Assert.Fail("No exception found :(((((");

        }

        [TestMethod]
        public void BuyCoffeeLessCoins_ResultFalse()
        {
            const bool EXPECTED_RESULT = false;
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(50);
            bool actualResult = coffeeMachine.GetCoffee(0);

            Assert.AreEqual(actualResult, EXPECTED_RESULT);
        }
        [TestMethod]
        public void BuyCoffeeEnoughCoins_ResultTrue()
        {
            const bool EXPECTED_RESULT = true;
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(100);
            coffeeMachine.InsertCoins(50);
            bool actualResult = coffeeMachine.GetCoffee(0);
            Assert.AreEqual(actualResult, EXPECTED_RESULT);
        }
        [TestMethod]
        public void BuyCoffeeNoCoins_ResultFalse()
        {
            const bool EXPECTED_RESULT = false;
            var coffeeMachine = new CoffeeMachine();
            bool actualResult = coffeeMachine.GetCoffee(0);
            Assert.AreEqual(actualResult, EXPECTED_RESULT);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ChooseCoffeeNotExist_ResultFalse()
        {
            var coffeeMachine = new CoffeeMachine();
            coffeeMachine.GetCoffee(10000);
            Assert.Fail("No exception found :(((((");
        }
    }
}
