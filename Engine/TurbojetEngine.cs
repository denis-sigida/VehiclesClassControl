namespace Vehicles.Engine
{
    class TurbojetEngine : IEngine
    {
        public TurbojetEngine(Fuel fuel, int capacity, int power, int fuelConsumption, float airFlow)
        {
            Fuel = fuel;
            Capacity = capacity;
            Power = power;
            FuelConsumption = fuelConsumption;
            AirFlow = airFlow;
        }
        public Fuel Fuel { get; set; }
        public int Capacity { get; set; }
        public int Power { get; set; }
        public int FuelConsumption { get; set; }
        public float AirFlow { get; set; }
    }
}
