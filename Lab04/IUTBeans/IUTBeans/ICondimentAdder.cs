using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUTBeans
{
    internal interface ICondimentAdder
    {
        Beverage AddCondiment(Beverage beverage);
    }
}
