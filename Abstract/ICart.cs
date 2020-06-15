using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    interface ICart
    {
        double TotalPriceWithVAT { get; set; }
    }
}
