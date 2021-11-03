namespace Vehicles.Model
{
    class Airplan : Transport
    {
        public Airplan(string firm, string model, string color, int passengerCapacity, float ceiling, float wingspan, IEngine engine, Appointment airClass)
        {
            Firm = firm;
            Model = model;
            Color = color;
            PassengerCapacity = passengerCapacity;
            FlightCeiling = ceiling;
            Wingspan = wingspan;
            Engine = engine;
            Type = TypeOfTransport.Air;
            Class = airClass;
        }
        public int PassengerCapacity { get; set; }
        public float FlightCeiling { get; set; }
        public float Wingspan { get; set; }
        public Appointment Class { get; set; }

        public override string ToString()
        {
            return $"Фирма самолета: {Firm}\n" +
                              $"Модель: {Model}\n" +
                              $"Цвет: {Color}\n" +
                              $"Мощность двигателя: {Engine.Power}\n" +
                              $"Тип двигателя: {Engine.Fuel}\n" +
                              $"Класс назначения: {Class}";
        }
    }
}
