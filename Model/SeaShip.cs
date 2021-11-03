namespace Vehicles.Model
{
    class SeaShip : Transport
    {
        public SeaShip(string firm, string model, string color, string name, int cargoCapacity, int numberOfDecks, IEngine engine, Appointment _class)
        {
            Firm = firm;
            Model = model;
            Color = color;
            Name = name;
            CargoCapacity = cargoCapacity;
            NumberOfDecks = numberOfDecks;
            Type = TypeOfTransport.Water;
            Engine = engine;
            Class = _class;

        }

        public int CargoCapacity { get; set; }
        public int NumberOfDecks { get; set; }
        public string Name { get; set; }
        public Appointment Class { get; set; }

        public override string ToString()
        {
            return $"Фирма судна: {Firm}\n" +
                              $"Модель судна: {Model}\n" +
                              $"Цвет: {Color}\n" +
                              $"Мощность двигателя: {Engine.Power}\n" +
                              $"Тип двигателя: {Engine.Fuel}\n" +
                              $"Класс назначения: {Class}";
        }
    }
}
