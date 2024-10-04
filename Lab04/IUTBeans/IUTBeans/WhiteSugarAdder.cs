using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class WhiteSugarAdder : ICondimentAdder
    {
        private ICondimentAdder nextAdder;
        private double whiteSugarPrice = 0.1;
        public WhiteSugarAdder(ICondimentAdder nextAdder)
        {
            this.nextAdder = nextAdder;
        }

        public Beverage AddCondiment(Beverage beverage)
        {
            beverage.Price += whiteSugarPrice;
            beverage.Description += "white sugar, ";
            
            if(nextAdder == null)
            {
                return beverage;
            }
            return nextAdder.AddCondiment(beverage);
        }
    }
}
