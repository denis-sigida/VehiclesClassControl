namespace Vehicles.Engine
{
    class InternalCombustionEngine : IEngine
    {
        public InternalCombustionEngine(Fuel fuel, int capacity, int power, int fuelConsumption, int oilConsumption)
        {
            Fuel = fuel;
            Capacity = capacity;
            Power = power;
            FuelConsumption = fuelConsumption;
            OilConsumption = oilConsumption;
        }
        public Fuel Fuel { get; set; }
        public int Capacity { get; set; }
        public int Power { get; set; }
        public int FuelConsumption { get; set; }
        public int OilConsumption { get; set; }
    }
}
