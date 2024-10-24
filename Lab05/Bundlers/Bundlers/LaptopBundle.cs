using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundlers
{
    internal class LaptopBundle : Bundle
    {
        public LaptopBundle()
        {
            addProduct(new KeyboardMouseBundle());
            addProduct(new Laptop());
        }
    }
}
