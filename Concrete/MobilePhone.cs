using System;

namespace ShopApp
{
    class MobilePhone : Product
    {
        public string InternalMemory { get; }
        public string RAMCapacity { get; }
        public string BatteryCapacity { get; }

        public MobilePhone(string name, string brand, string model, string property, double rawCost, int selectedPiece, double vatRate, string internalMemory, string ramCapacity, string batteryCapacity) : base(name, brand, model, property, rawCost, selectedPiece, vatRate)
        {
            InternalMemory = internalMemory;
            RAMCapacity = ramCapacity;
            BatteryCapacity = batteryCapacity;

            Random random = new Random();
            StockAmount = random.Next(1, 100);
        }
    }
}
