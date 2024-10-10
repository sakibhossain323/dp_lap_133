using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class WhiteSugar : ICondiment
    {
        private ICondiment? nextAdder;
        private double whiteSugarPrice = 0.1;
        private string whiteSugarDescription = "White sugar";
        public WhiteSugar()
        {
            nextAdder = null;
        }

        public WhiteSugar(ICondiment nextAdder)
        {
            this.nextAdder = nextAdder;
        }

        public string getDescription()
        {
            if(nextAdder == null)
            {
                return whiteSugarDescription;
            }

            return whiteSugarDescription + ", " + nextAdder.getDescription();
        }

        public double getPrice()
        {
            if(nextAdder == null)
            {
                return whiteSugarPrice;
            }

            return whiteSugarPrice + nextAdder.getPrice();
        }
    }
}
