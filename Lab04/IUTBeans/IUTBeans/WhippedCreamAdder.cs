using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class WhippedCreamAdder : ICondimentAdder
    {
        private ICondimentAdder nextAdder;
        private double whippedCreamPrice = 0.5;
        public WhippedCreamAdder(ICondimentAdder nextAdder)
        {
            this.nextAdder = nextAdder;
        }

        public Beverage AddCondiment(Beverage beverage)
        {
            beverage.Price += whippedCreamPrice;
            beverage.Description += "whipped cream, ";
            
            if(nextAdder == null)
            {
                return beverage;
            }
            return nextAdder.AddCondiment(beverage);
        }
    }
}
