using System;

namespace ShopApp
{
    class Product : IProduct
    {
        public string Name { get; }
        public string Brand { get; }
        public string Model { get; }
        public string Property { get; }
        public int StockAmount { get; set; }
        public double RawCost { get; }
        public int SelectedPieces { get; set; }
        public double VATRate { get; set; }

        public Product(string name, string brand, string model, string property, double rawCost, int selectedPiece, double vatRate)
        {
            Name = name;
            Brand = brand;
            Model = model;
            Property = property;
            RawCost = rawCost;
            SelectedPieces = selectedPiece;
            VATRate = vatRate;
        }
    }
}
