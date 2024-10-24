using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundlers
{
    internal abstract class Bundle : IProduct
    {   
        private List<IProduct> _products = new List<IProduct>();

        public void addProduct(IProduct product)
        {
            _products.Add(product);
        }
        public string getDetails()
        {
            string details = "";
            foreach (IProduct product in _products)
            {
                details += product.getDetails() + ", ";
            }

            return details;
        }

        public double getPrice()
        {
            double price = 0;
            foreach (IProduct product in _products)
            {
                price += product.getPrice();
            }
            return price;
        }
    }
}
