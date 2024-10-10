using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class Latte : Beverage
    {
        public Latte(): base()
        {
            Description = "Latte";
            Price = 2.99;
        }

        public Latte(ICondiment condiment):  base(condiment)
        {
            Description = "Latte with " + condiment.getDescription();
            Price = 2.99 + condiment.getPrice();
        }
    }
}
