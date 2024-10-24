using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundlers
{
    internal class Mouse : IProduct
    {
        private string _details;
        private double _price;
        public Mouse()
        {
            _details = "Mouse";
            _price = 20;
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
