using System;
using System.Windows.Forms;

namespace ShopApp
{
    class Cart : ICart
    {
        public double TotalPriceWithVAT { get; set; }
    }
}
