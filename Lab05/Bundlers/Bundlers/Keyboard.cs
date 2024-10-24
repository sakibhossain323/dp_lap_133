using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundlers
{
    internal class Keyboard : IProduct
    {
        private string _details;
        private double _price;
        public Keyboard()
        {
            _details = "Keyboard";
            _price = 50;
        }
        public string getDetails()
        {
            return _details;
        }

        public double getPrice()
        {
            return _price;
        }
    }
}
