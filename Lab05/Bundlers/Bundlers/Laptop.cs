using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundlers
{
    internal class Laptop : IProduct
    {
        private string _details;
        private double _price;
        public Laptop()
        {
            _details = "Laptop";
            _price = 1000;
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
