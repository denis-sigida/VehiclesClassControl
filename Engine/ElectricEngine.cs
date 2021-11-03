namespace Vehicles.Engine
{
    class ElectricEngine : IEngine
    {
        public ElectricEngine(int capacity, int power)
        {
            Fuel = Fuel.Electro;
            Capacity = capacity;
            Power = power;
        }
        public Fuel Fuel { get; set; }
        public int Capacity { get; set; }
        public int Power { get; set; }
        public int FuelConsumption { get; set; }
    }
}
