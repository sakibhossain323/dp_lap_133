using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bundlers
{
    internal class KeyboardMouseBundle: Bundle
    {
        public KeyboardMouseBundle()
        {
            addProduct(new Keyboard());
            addProduct(new Mouse());
        }
    }
}
