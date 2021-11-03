namespace Vehicles
{
    interface IEngine
    {
        public Fuel Fuel { get; set; }
        int Capacity { get; set; }
        int Power { get; set; }
        int FuelConsumption { get; set; }

    }
}
