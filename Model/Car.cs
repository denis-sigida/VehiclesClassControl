namespace Vehicles.Model
{
    class Car : Transport
    {
        public Car(string firm, string model, string color, IEngine engine, CarClass _class)
        {
            Firm = firm;
            Model = model;
            Color = color;
            Engine = engine;
            Class = _class;
            Type = TypeOfTransport.Terrestrial;
        }

        public CarClass Class { get; set; }

        public override string ToString()
        {
            return $"Фирма машины: {Firm}\n" +
                              $"Модель машины: {Model}\n" +
                              $"Цвет машины: {Color}\n" +
                              $"Мощность двигателя: {Engine.Power}\n" +
                              $"Тип двигателя: {Engine.Fuel}\n" +
                              $"Класс автомобиля: {Class}";
        }
    }
}
