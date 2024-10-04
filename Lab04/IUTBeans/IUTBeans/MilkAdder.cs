using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class MilkAdder : ICondimentAdder
    {
        private ICondimentAdder nextAdder;
        private double milkPrice = 0.5;
        public MilkAdder(ICondimentAdder nextAdder)
        {
            this.nextAdder = nextAdder;
        }

        public Beverage AddCondiment(Beverage beverage)
        {
            beverage.Price += milkPrice;
            beverage.Description += "milk, ";
            
            if(nextAdder == null)
            {
                return beverage;
            }
            return nextAdder.AddCondiment(beverage);
        }
    }
}
