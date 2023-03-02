using System;
using System.Collections.Generic;
using System.Linq;

namespace CoffeeMachineLib
{
    public class CoffeeMachine
    {
        private int _coins;
        public int GetCoins { get { return _coins; } }
        public int SetCoins { set { _coins = value; } }

        List<CoffeeType> GenerateCoffeeTypes()
        {
            List<CoffeeType> coffees = new List<CoffeeType>();
            coffees.Add(new CoffeeType(0, "Latte", 150));
            coffees.Add(new CoffeeType(1, "Espresso", 120));
            coffees.Add(new CoffeeType(2, "Liquid Garbage", 500));
            return coffees;
        }

        public void InsertCoins(int coins)
        {
            if (Enum.IsDefined(typeof(Coin), coins))
            {
                setCoins = getCoins + coins;
                Console.WriteLine("Your balance is {0}", getCoins);
            }
            else
            {
                throw new CoinNotValidException("There is no such type of coins: " + coins);
            }
        }

        public void WithdrawCoins()
        {
            Console.WriteLine("Your change is {0}", getCoins);
            var coinsGroup = Enum.GetValues(typeof(Coin)).Cast<Coin>().ToArray();
            List<int> changeGroup = new List<int>();
            int currentBalance = getCoins;
            while(currentBalance != 0)
            {
                for(int coinsIterator = coinsGroup.Length - 1; coinsIterator > 0; coinsIterator--)
                {
                    if(currentBalance - coinsGroup[coinsIterator] >= 0)
                    {
                        changeGroup.Add((int)coinsGroup[coinsIterator]);
                        currentBalance -= (int)coinsGroup[coinsIterator];
                    }
                }
            }
            setCoins = 0;
            Console.WriteLine("Your change in coins: ");
            changeGroup.ForEach(coin => Console.Write(coin + " "));
        }
        public bool GetCoffee(int coffeeTypeId)
        {
            int currentBalance = getCoins;
            List<CoffeeType> coffees = GenerateCoffeeTypes();
            try
            {
                if (currentBalance >= coffees[coffeeTypeId].CoffeePrice)
                {
                    setCoins = currentBalance - coffees[coffeeTypeId].CoffeePrice;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(IndexOutOfRangeException indexException)
            {
                
                return false;
            }
        }
    }
}