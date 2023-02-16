using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineLib
{
    class CoffeeType
    {
        public CoffeeType(int id, string coffeeName, int coffeePrice)
        {
            _id = id;
            _coffeeName = coffeeName;
            _coffeePrice = coffeePrice;
        }

        private int _id;
        private string _coffeeName;
        private int _coffeePrice;

        public int Id { get { return _id; } set { _id = value; } }
        public string CoffeeName { get { return _coffeeName; } set { _coffeeName = value; } }
        public int CoffeePrice { get { return _coffeePrice; } set { _coffeePrice = value; } }
    }
}
