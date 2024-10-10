using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal class WhippedCream : ICondiment
    {
        private ICondiment? nextAdder;
        private double whippedCreamPrice = 0.5;
        private string whippedCreamDescription = "Whipped cream";
        public WhippedCream()
        {
            nextAdder = null;
        }

        public WhippedCream(ICondiment nextAdder)
        {
            this.nextAdder = nextAdder;
        }

        public string getDescription()
        {
            if(nextAdder == null)
            {
                return whippedCreamDescription;
            }

            return whippedCreamDescription + ", " + nextAdder.getDescription();
        }

        public double getPrice()
        {
            if(nextAdder == null)
            {
                return whippedCreamPrice;
            }

            return whippedCreamPrice + nextAdder.getPrice();
        }

    }
}
