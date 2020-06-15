using System;

namespace ShopApp
{
    class LedTv : Product
    {
        public string ScreenSize { get; }
        public string ScreenResolution { get; }

        public LedTv(string name, string brand, string model, string property, double rawCost, int selectedPiece, double vatRate, string screenSize, string screenResolution) : base(name, brand, model, property, rawCost, selectedPiece, vatRate)
        {
            ScreenSize = screenSize;
            ScreenResolution = screenResolution;

            Random random = new Random();
            StockAmount = random.Next(1, 100);
        }
    }
}
