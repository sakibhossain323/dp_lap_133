using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal abstract class Beverage
    {
        private ICondiment? condiment;
        public double Price { get; set; }
        public string Description { get; set; }

        protected Beverage()
        {
            condiment = null;
        }

        protected Beverage(ICondiment condiment)
        {
            this.condiment = condiment;
        }

        public override string ToString()
        {
            return Description + " $" + Price;
        }
    }
}
