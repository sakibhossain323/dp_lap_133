using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class Espresso : Beverage
    {
        public Espresso(): base()
        {
            Description = "Espresso";
            Price = 1.99;
        }

        public Espresso(ICondiment condiment):  base(condiment)
        {
            Description = "Espresso with " +  condiment.getDescription();
            Price = 1.99 + condiment.getPrice();
        }
    }
}
