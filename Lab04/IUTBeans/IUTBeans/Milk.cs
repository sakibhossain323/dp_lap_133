namespace IUTBeans
{
    internal class Milk : ICondiment
    {
        private ICondiment? nextCondiment;
        private double condimentPrice = 0.5;
        private string condimentDescription = " Milk";

        public Milk()
        {
            this.nextCondiment = null;
        }
        public Milk(ICondiment nextCondiment)
        {
            this.nextCondiment = nextCondiment;
        }

        public string getDescription()
        {
            if(nextCondiment == null)
            {
                return condimentDescription + ".";
            }
            return condimentDescription+", " + nextCondiment.getDescription();
        }

        public double getPrice()
        {
            if(nextCondiment == null)
            {
                return condimentPrice;
            }
            return condimentPrice + nextCondiment.getPrice();
        }
    }
}
