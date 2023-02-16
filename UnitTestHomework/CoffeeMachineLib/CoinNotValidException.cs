using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineLib
{
    [Serializable]
    public class CoinNotValidException : Exception
    {
        public CoinNotValidException() { }

        public CoinNotValidException(string message) : base(message) { }

        public CoinNotValidException(string message, Exception inner) : base(message, inner) { }
    }
}
