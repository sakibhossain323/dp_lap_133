using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class Cappuccino : Beverage
    {
        public Cappuccino(): base()
        {
            Description = "Cappuccino";
            Price = 3.49;
        }

        public Cappuccino(ICondiment condiment):  base(condiment)
        {
            Description = "Cappuccino with " + condiment.getDescription();
            Price = 3.49 + condiment.getPrice();
        }
    }
}
