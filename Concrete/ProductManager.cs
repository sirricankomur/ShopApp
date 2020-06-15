using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class ProductManager
    {
        public double ApplyVAT(Product product)
        {
            return Math.Round((product.VATRate * product.RawCost * product.SelectedPieces), 2);
        }
    }
}
