using System;

namespace ShopApp
{
    class Refrigerator : Product
    {
        public double TotalCapacity { get; }
        public string EnergyClass { get; }

        public Refrigerator(string name, string brand, string model, string property, int rawCost, int selectedPiece, double vatRate, double totalCapacity, string energyClass) : base(name, brand, model, property, rawCost, selectedPiece, vatRate)
        {
            TotalCapacity = totalCapacity;
            EnergyClass = energyClass;

            Random random = new Random();
            StockAmount = random.Next(1, 100);
        }
    }
}
