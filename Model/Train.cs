namespace Vehicles.Model
{
    class Train : Transport
    {
        public Train(string firm, string model, string color, float weight, int numberOfSection, IEngine engine, Appointment _class)
        {
            Firm = firm;
            Model = model;
            Color = color;
            Type = TypeOfTransport.Railway;
            Engine = engine;
            Weight = weight;
            NumberOfSection = numberOfSection;
            Class = _class;
        }

        public float Weight { get; set; }
        public int NumberOfSection { get; set; }
        public Appointment Class { get; set; }

        public override string ToString()
        {
            return $"Фирма поезда: {Firm}\n" +
                              $"Модель: {Model}\n" +
                              $"Цвет: {Color}\n" +
                              $"Мощность двигателя: {Engine.Power}\n" +
                              $"Тип двигателя: {Engine.Fuel}\n" +
                              $"Класс назначения: {Class}";
        }
    }

}
