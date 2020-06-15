namespace ShopApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceWithKDV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbxPriceWithKDV = new System.Windows.Forms.ListBox();
            this.lbxProduct = new System.Windows.Forms.ListBox();
            this.lbxAmount = new System.Windows.Forms.ListBox();
            this.lblPriceWithKDV = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxPricesWithoutKDV = new System.Windows.Forms.GroupBox();
            this.lblStockPhone = new System.Windows.Forms.Label();
            this.nudAmountPhone = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPricePhone = new System.Windows.Forms.Label();
            this.lblStockLaptop = new System.Windows.Forms.Label();
            this.nudAmountLaptop = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPriceLaptop = new System.Windows.Forms.Label();
            this.lblStockFridge = new System.Windows.Forms.Label();
            this.nudAmountFridge = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPriceFridge = new System.Windows.Forms.Label();
            this.lblStockTV = new System.Windows.Forms.Label();
            this.nudAmountTV = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPriceTV = new System.Windows.Forms.Label();
            this.pbxPhone = new System.Windows.Forms.PictureBox();
            this.pbxTV = new System.Windows.Forms.PictureBox();
            this.pbxLaptop = new System.Windows.Forms.PictureBox();
            this.pbxFridge = new System.Windows.Forms.PictureBox();
            this.gbxOrderSummary.SuspendLayout();
            this.gbxPricesWithoutKDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountFridge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLaptop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFridge)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxOrderSummary
            // 
            this.gbxOrderSummary.Controls.Add(this.lblTotalPriceWithKDV);
            this.gbxOrderSummary.Controls.Add(this.lblTotal);
            this.gbxOrderSummary.Controls.Add(this.lbxPriceWithKDV);
            this.gbxOrderSummary.Controls.Add(this.lbxProduct);
            this.gbxOrderSummary.Controls.Add(this.lbxAmount);
            this.gbxOrderSummary.Controls.Add(this.lblPriceWithKDV);
            this.gbxOrderSummary.Controls.Add(this.lblProduct);
            this.gbxOrderSummary.Controls.Add(this.lblAmount);
            this.gbxOrderSummary.Location = new System.Drawing.Point(445, 12);
            this.gbxOrderSummary.Name = "gbxOrderSummary";
            this.gbxOrderSummary.Size = new System.Drawing.Size(400, 388);
            this.gbxOrderSummary.TabIndex = 7;
            this.gbxOrderSummary.TabStop = false;
            this.gbxOrderSummary.Text = "Your Order";
            // 
            // lblTotalPriceWithKDV
            // 
            this.lblTotalPriceWithKDV.AutoSize = true;
            this.lblTotalPriceWithKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPriceWithKDV.Location = new System.Drawing.Point(211, 315);
            this.lblTotalPriceWithKDV.Name = "lblTotalPriceWithKDV";
            this.lblTotalPriceWithKDV.Size = new System.Drawing.Size(25, 26);
            this.lblTotalPriceWithKDV.TabIndex = 7;
            this.lblTotalPriceWithKDV.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotal.Location = new System.Drawing.Point(43, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(162, 20);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total Price With VAT: ";
            // 
            // lbxPriceWithKDV
            // 
            this.lbxPriceWithKDV.FormattingEnabled = true;
            this.lbxPriceWithKDV.Location = new System.Drawing.Point(271, 35);
            this.lbxPriceWithKDV.Name = "lbxPriceWithKDV";
            this.lbxPriceWithKDV.Size = new System.Drawing.Size(123, 212);
            this.lbxPriceWithKDV.TabIndex = 5;
            // 
            // lbxProduct
            // 
            this.lbxProduct.FormattingEnabled = true;
            this.lbxProduct.Location = new System.Drawing.Point(117, 35);
            this.lbxProduct.Name = "lbxProduct";
            this.lbxProduct.Size = new System.Drawing.Size(148, 212);
            this.lbxProduct.TabIndex = 4;
            // 
            // lbxAmount
            // 
            this.lbxAmount.FormattingEnabled = true;
            this.lbxAmount.Location = new System.Drawing.Point(6, 35);
            this.lbxAmount.Name = "lbxAmount";
            this.lbxAmount.Size = new System.Drawing.Size(105, 212);
            this.lbxAmount.TabIndex = 3;
            // 
            // lblPriceWithKDV
            // 
            this.lblPriceWithKDV.AutoSize = true;
            this.lblPriceWithKDV.Location = new System.Drawing.Point(292, 19);
            this.lblPriceWithKDV.Name = "lblPriceWithKDV";
            this.lblPriceWithKDV.Size = new System.Drawing.Size(80, 13);
            this.lblPriceWithKDV.TabIndex = 2;
            this.lblPriceWithKDV.Text = "Price With VAT";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(169, 16);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(16, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(84, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Selected Pieces";
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(226, 481);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(160, 23);
            this.btnClean.TabIndex = 6;
            this.btnClean.Text = "Clear Cart";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(60, 481);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Products to Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxPricesWithoutKDV
            // 
            this.gbxPricesWithoutKDV.Controls.Add(this.lblStockPhone);
            this.gbxPricesWithoutKDV.Controls.Add(this.nudAmountPhone);
            this.gbxPricesWithoutKDV.Controls.Add(this.label17);
            this.gbxPricesWithoutKDV.Controls.Add(this.label18);
            this.gbxPricesWithoutKDV.Controls.Add(this.label19);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblPricePhone);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblStockLaptop);
            this.gbxPricesWithoutKDV.Controls.Add(this.nudAmountLaptop);
            this.gbxPricesWithoutKDV.Controls.Add(this.label7);
            this.gbxPricesWithoutKDV.Controls.Add(this.label13);
            this.gbxPricesWithoutKDV.Controls.Add(this.label14);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblPriceLaptop);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblStockFridge);
            this.gbxPricesWithoutKDV.Controls.Add(this.nudAmountFridge);
            this.gbxPricesWithoutKDV.Controls.Add(this.label9);
            this.gbxPricesWithoutKDV.Controls.Add(this.label10);
            this.gbxPricesWithoutKDV.Controls.Add(this.label11);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblPriceFridge);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblStockTV);
            this.gbxPricesWithoutKDV.Controls.Add(this.nudAmountTV);
            this.gbxPricesWithoutKDV.Controls.Add(this.label5);
            this.gbxPricesWithoutKDV.Controls.Add(this.label3);
            this.gbxPricesWithoutKDV.Controls.Add(this.label2);
            this.gbxPricesWithoutKDV.Controls.Add(this.lblPriceTV);
            this.gbxPricesWithoutKDV.Controls.Add(this.pbxPhone);
            this.gbxPricesWithoutKDV.Controls.Add(this.pbxTV);
            this.gbxPricesWithoutKDV.Controls.Add(this.pbxLaptop);
            this.gbxPricesWithoutKDV.Controls.Add(this.pbxFridge);
            this.gbxPricesWithoutKDV.Location = new System.Drawing.Point(12, 12);
            this.gbxPricesWithoutKDV.Name = "gbxPricesWithoutKDV";
            this.gbxPricesWithoutKDV.Size = new System.Drawing.Size(427, 463);
            this.gbxPricesWithoutKDV.TabIndex = 4;
            this.gbxPricesWithoutKDV.TabStop = false;
            this.gbxPricesWithoutKDV.Text = "VAT- free Prices";
            // 
            // lblStockPhone
            // 
            this.lblStockPhone.AutoSize = true;
            this.lblStockPhone.Location = new System.Drawing.Point(267, 414);
            this.lblStockPhone.Name = "lblStockPhone";
            this.lblStockPhone.Size = new System.Drawing.Size(13, 13);
            this.lblStockPhone.TabIndex = 31;
            this.lblStockPhone.Text = "0";
            // 
            // nudAmountPhone
            // 
            this.nudAmountPhone.Location = new System.Drawing.Point(316, 431);
            this.nudAmountPhone.Name = "nudAmountPhone";
            this.nudAmountPhone.Size = new System.Drawing.Size(46, 20);
            this.nudAmountPhone.TabIndex = 30;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(228, 433);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(2);
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Selected Pieces:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(228, 412);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(2);
            this.label18.Size = new System.Drawing.Size(42, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "Stock:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(228, 391);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(2);
            this.label19.Size = new System.Drawing.Size(38, 17);
            this.label19.TabIndex = 26;
            this.label19.Text = "Price:";
            // 
            // lblPricePhone
            // 
            this.lblPricePhone.AutoSize = true;
            this.lblPricePhone.Location = new System.Drawing.Point(267, 393);
            this.lblPricePhone.Name = "lblPricePhone";
            this.lblPricePhone.Size = new System.Drawing.Size(13, 13);
            this.lblPricePhone.TabIndex = 28;
            this.lblPricePhone.Text = "0";
            // 
            // lblStockLaptop
            // 
            this.lblStockLaptop.AutoSize = true;
            this.lblStockLaptop.Location = new System.Drawing.Point(45, 414);
            this.lblStockLaptop.Name = "lblStockLaptop";
            this.lblStockLaptop.Size = new System.Drawing.Size(13, 13);
            this.lblStockLaptop.TabIndex = 25;
            this.lblStockLaptop.Text = "0";
            // 
            // nudAmountLaptop
            // 
            this.nudAmountLaptop.Location = new System.Drawing.Point(94, 431);
            this.nudAmountLaptop.Name = "nudAmountLaptop";
            this.nudAmountLaptop.Size = new System.Drawing.Size(46, 20);
            this.nudAmountLaptop.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 433);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(2);
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Selected Pieces:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 412);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(2);
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 21;
            this.label13.Text = "Stock:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 391);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(2);
            this.label14.Size = new System.Drawing.Size(38, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Price:";
            // 
            // lblPriceLaptop
            // 
            this.lblPriceLaptop.AutoSize = true;
            this.lblPriceLaptop.Location = new System.Drawing.Point(45, 393);
            this.lblPriceLaptop.Name = "lblPriceLaptop";
            this.lblPriceLaptop.Size = new System.Drawing.Size(13, 13);
            this.lblPriceLaptop.TabIndex = 22;
            this.lblPriceLaptop.Text = "0";
            // 
            // lblStockFridge
            // 
            this.lblStockFridge.AutoSize = true;
            this.lblStockFridge.Location = new System.Drawing.Point(267, 195);
            this.lblStockFridge.Name = "lblStockFridge";
            this.lblStockFridge.Size = new System.Drawing.Size(13, 13);
            this.lblStockFridge.TabIndex = 19;
            this.lblStockFridge.Text = "0";
            // 
            // nudAmountFridge
            // 
            this.nudAmountFridge.Location = new System.Drawing.Point(316, 212);
            this.nudAmountFridge.Name = "nudAmountFridge";
            this.nudAmountFridge.Size = new System.Drawing.Size(46, 20);
            this.nudAmountFridge.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 214);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(2);
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Selected Pieces:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 193);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2);
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Stock:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 172);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(2);
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Price:";
            // 
            // lblPriceFridge
            // 
            this.lblPriceFridge.AutoSize = true;
            this.lblPriceFridge.Location = new System.Drawing.Point(267, 174);
            this.lblPriceFridge.Name = "lblPriceFridge";
            this.lblPriceFridge.Size = new System.Drawing.Size(13, 13);
            this.lblPriceFridge.TabIndex = 16;
            this.lblPriceFridge.Text = "0";
            // 
            // lblStockTV
            // 
            this.lblStockTV.AutoSize = true;
            this.lblStockTV.Location = new System.Drawing.Point(45, 195);
            this.lblStockTV.Name = "lblStockTV";
            this.lblStockTV.Size = new System.Drawing.Size(13, 13);
            this.lblStockTV.TabIndex = 13;
            this.lblStockTV.Text = "0";
            // 
            // nudAmountTV
            // 
            this.nudAmountTV.Location = new System.Drawing.Point(94, 212);
            this.nudAmountTV.Name = "nudAmountTV";
            this.nudAmountTV.Size = new System.Drawing.Size(46, 20);
            this.nudAmountTV.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(2);
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Selected Pieces:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 193);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 172);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price:";
            // 
            // lblPriceTV
            // 
            this.lblPriceTV.AutoSize = true;
            this.lblPriceTV.Location = new System.Drawing.Point(45, 174);
            this.lblPriceTV.Name = "lblPriceTV";
            this.lblPriceTV.Size = new System.Drawing.Size(13, 13);
            this.lblPriceTV.TabIndex = 8;
            this.lblPriceTV.Text = "0";
            // 
            // pbxPhone
            // 
            this.pbxPhone.Image = global::ShopApp.Properties.Resources.CepTelefonu;
            this.pbxPhone.Location = new System.Drawing.Point(231, 238);
            this.pbxPhone.Name = "pbxPhone";
            this.pbxPhone.Size = new System.Drawing.Size(190, 150);
            this.pbxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhone.TabIndex = 4;
            this.pbxPhone.TabStop = false;
            // 
            // pbxTV
            // 
            this.pbxTV.Image = global::ShopApp.Properties.Resources.LedTv;
            this.pbxTV.Location = new System.Drawing.Point(6, 19);
            this.pbxTV.Name = "pbxTV";
            this.pbxTV.Size = new System.Drawing.Size(190, 150);
            this.pbxTV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTV.TabIndex = 3;
            this.pbxTV.TabStop = false;
            // 
            // pbxLaptop
            // 
            this.pbxLaptop.Image = global::ShopApp.Properties.Resources.Laptop;
            this.pbxLaptop.Location = new System.Drawing.Point(6, 238);
            this.pbxLaptop.Name = "pbxLaptop";
            this.pbxLaptop.Size = new System.Drawing.Size(190, 150);
            this.pbxLaptop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLaptop.TabIndex = 2;
            this.pbxLaptop.TabStop = false;
            // 
            // pbxFridge
            // 
            this.pbxFridge.Image = global::ShopApp.Properties.Resources.Buzdolabi;
            this.pbxFridge.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxFridge.InitialImage")));
            this.pbxFridge.Location = new System.Drawing.Point(231, 19);
            this.pbxFridge.Name = "pbxFridge";
            this.pbxFridge.Size = new System.Drawing.Size(190, 150);
            this.pbxFridge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFridge.TabIndex = 1;
            this.pbxFridge.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 532);
            this.Controls.Add(this.gbxOrderSummary);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbxPricesWithoutKDV);
            this.Name = "Form1";
            this.Text = "Shopping Cart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxOrderSummary.ResumeLayout(false);
            this.gbxOrderSummary.PerformLayout();
            this.gbxPricesWithoutKDV.ResumeLayout(false);
            this.gbxPricesWithoutKDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountFridge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLaptop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFridge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrderSummary;
        private System.Windows.Forms.Label lblTotalPriceWithKDV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbxPriceWithKDV;
        private System.Windows.Forms.ListBox lbxProduct;
        private System.Windows.Forms.ListBox lbxAmount;
        private System.Windows.Forms.Label lblPriceWithKDV;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxPricesWithoutKDV;
        private System.Windows.Forms.Label lblStockPhone;
        private System.Windows.Forms.NumericUpDown nudAmountPhone;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPricePhone;
        private System.Windows.Forms.Label lblStockLaptop;
        private System.Windows.Forms.NumericUpDown nudAmountLaptop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPriceLaptop;
        private System.Windows.Forms.Label lblStockFridge;
        private System.Windows.Forms.NumericUpDown nudAmountFridge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPriceFridge;
        private System.Windows.Forms.Label lblStockTV;
        private System.Windows.Forms.NumericUpDown nudAmountTV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPriceTV;
        private System.Windows.Forms.PictureBox pbxPhone;
        private System.Windows.Forms.PictureBox pbxTV;
        private System.Windows.Forms.PictureBox pbxLaptop;
        private System.Windows.Forms.PictureBox pbxFridge;
    }
}

