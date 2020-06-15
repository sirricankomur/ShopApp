using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    class CartManager
    {
        public ListBox AmountListBox { get; }
        public ListBox ProductListBox { get; }
        public ListBox PriceWithKDVListBox { get; }

        public CartManager(ListBox amountlistBox, ListBox productlistBox, ListBox priceWithKDVlistBox)
        {
            AmountListBox = amountlistBox;
            ProductListBox = productlistBox;
            PriceWithKDVListBox = priceWithKDVlistBox;
        }

        public int AddToCart(Product product)
        {
            ProductManager productManager = new ProductManager();

            //Has the product been selected?
            if (product.SelectedPieces != 0)
            {
                //Is it in stock?
                if (product.StockAmount - product.SelectedPieces >= 0)
                {
                    product.StockAmount -= product.SelectedPieces;
                    AmountListBox.Items.Add(product.SelectedPieces);
                    ProductListBox.Items.Add(product.Name);
                    PriceWithKDVListBox.Items.Add(productManager.ApplyVAT(product));
                }
                else
                {
                    MessageBox.Show(product.Name + "\nUnfortunately, there is not enough stock in the product!");
                }
            }

            return product.StockAmount;
        }
    }
}
