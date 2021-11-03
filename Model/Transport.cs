namespace Vehicles.Model
{
    class Transport
    {
        public string Firm { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public TypeOfTransport Type { get; set; }
        public IEngine Engine { get; set; }

        public override string ToString()
        {
            return $"Вид транспорт: {Type}\n" +
                   $"Фирма: {Firm}\n" +
                   $"Двигатель типа: {Engine.Fuel}\n" +
                   $"Мощность двигателя: {Engine.Power}";
        }
    }
}
