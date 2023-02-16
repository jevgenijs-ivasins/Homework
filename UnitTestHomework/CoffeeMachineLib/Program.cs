using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(20);

            Console.ReadLine();
        }
    }
}
