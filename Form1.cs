using System;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class Form1 : Form
    {
        LedTv ledTv;
        Refrigerator refrigerator;
        Laptop laptop;
        MobilePhone mobilePhone;
        Cart cart;
        CartManager cartManager;
        ProductManager productManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ledTv = new LedTv("Led TV", "Samsung", "49RU7300", "Television", 3050, 0, 0.18, "49 inch", "4K");
            lblPriceTV.Text = ledTv.RawCost.ToString();
            lblStockTV.Text = ledTv.StockAmount.ToString();

            System.Threading.Thread.Sleep(500);
            refrigerator = new Refrigerator("Refrigerator", "Bosch", "KGN86AI42N", "White Goods", 7299, 0, 0.05, 682, "A+++");
            lblPriceFridge.Text = refrigerator.RawCost.ToString();
            lblStockFridge.Text = refrigerator.StockAmount.ToString();

            System.Threading.Thread.Sleep(500);
            laptop = new Laptop("Laptop", "Microsoft", "Surface 3", "Computer", 15100, 0, 0.15, "15 inch", "2496 x 1664 pixel", "1 TB", "16 GB", "46 Wh");
            lblPriceLaptop.Text = laptop.RawCost.ToString();
            lblStockLaptop.Text = laptop.StockAmount.ToString();

            System.Threading.Thread.Sleep(500);
            mobilePhone = new MobilePhone("Mobile Phone", "Honor", "9X", "Phone", 2200, 0, 0.20, "128 GB", "4 GB", "4000 mAh");
            lblPricePhone.Text = mobilePhone.RawCost.ToString();
            lblStockPhone.Text = mobilePhone.StockAmount.ToString();          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cart = new Cart();
            cartManager = new CartManager(lbxAmount, lbxProduct, lbxPriceWithKDV);
            productManager = new ProductManager();

            lbxAmount.Items.Clear();
            lbxProduct.Items.Clear();
            lbxPriceWithKDV.Items.Clear();
          
            ledTv.SelectedPieces = Convert.ToInt32(nudAmountTV.Value);
            refrigerator.SelectedPieces = Convert.ToInt32(nudAmountFridge.Value);
            laptop.SelectedPieces = Convert.ToInt32(nudAmountLaptop.Value);
            mobilePhone.SelectedPieces = Convert.ToInt32(nudAmountPhone.Value);
          
            lblStockTV.Text = cartManager.AddToCart(ledTv).ToString();
            lblStockFridge.Text = cartManager.AddToCart(refrigerator).ToString();
            lblStockLaptop.Text = cartManager.AddToCart(laptop).ToString();
            lblStockPhone.Text = cartManager.AddToCart(mobilePhone).ToString();

            cart.TotalPriceWithVAT += productManager.ApplyVAT(ledTv);
            cart.TotalPriceWithVAT += productManager.ApplyVAT(refrigerator);
            cart.TotalPriceWithVAT += productManager.ApplyVAT(laptop);
            cart.TotalPriceWithVAT += productManager.ApplyVAT(mobilePhone);
      
            lblTotalPriceWithKDV.Text = cart.TotalPriceWithVAT.ToString();

            int counter = lbxProduct.Items.Count;
            if (counter == 0)
            {
                lblTotalPriceWithKDV.Text = 0.ToString();
            }
        }

        private bool IsEmptyListBoxAmount()
        {
            bool isEmpty = true;

            //Is empty the Amount ListBox?
            if (lbxAmount.Items.Count > 0)
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {       
            int counter = lbxProduct.Items.Count;

            
            if (IsEmptyListBoxAmount() == false)
            {
                //Add the products to stock again
                for (int i = 0; i < counter; i++)
                {
                    if (lbxProduct.Items[i].ToString() == ledTv.Name)
                    {
                        ledTv.StockAmount += Convert.ToInt32(lbxAmount.Items[i]);
                    }
                    else if (lbxProduct.Items[i].ToString() == refrigerator.Name)
                    {
                        refrigerator.StockAmount += Convert.ToInt32(lbxAmount.Items[i]);
                    }
                    else if (lbxProduct.Items[i].ToString() == laptop.Name)
                    {
                        laptop.StockAmount += Convert.ToInt32(lbxAmount.Items[i]);
                    }
                    else if (lbxProduct.Items[i].ToString() == mobilePhone.Name)
                    {
                        mobilePhone.StockAmount += Convert.ToInt32(lbxAmount.Items[i]);
                    }
                }

                lblStockTV.Text = (ledTv.StockAmount).ToString();
                lblStockFridge.Text = (refrigerator.StockAmount).ToString();
                lblStockLaptop.Text = (laptop.StockAmount).ToString();
                lblStockPhone.Text = (mobilePhone.StockAmount).ToString();
            }
            lbxAmount.Items.Clear();
            lbxProduct.Items.Clear();
            lbxPriceWithKDV.Items.Clear();

            lblTotalPriceWithKDV.Text = 0.ToString();
        }
     
    }
}
