using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    interface IProduct
    {
        string Name { get; }
        string Brand { get; }
        string Model { get; }
        string Property { get; }
        int StockAmount { get; set; }
        double RawCost { get; }
        int SelectedPieces { get; set; }      
    }
}
