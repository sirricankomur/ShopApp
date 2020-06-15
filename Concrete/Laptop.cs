using System;

namespace ShopApp
{
    class Laptop : Product
    {
        public string ScreenSize { get; }
        public string ScreenResolution { get; }
        public string InternalMemory { get; }
        public string RAMCapacity { get; }
        public string BatteryCapacity { get; }

        public Laptop(string name, string brand, string model, string property, double rawCost, int selectedPiece, double vatRate, string screenSize, string screenResolution, string internalMemory, string ramCapacity, string batteryCapacity) : base(name, brand, model, property, rawCost, selectedPiece, vatRate)
        {
            ScreenSize = screenSize;
            ScreenResolution = screenResolution;
            InternalMemory = internalMemory;
            RAMCapacity = ramCapacity;
            BatteryCapacity = batteryCapacity;

            Random random = new Random();
            StockAmount = random.Next(1, 100);
        }
    }
}
