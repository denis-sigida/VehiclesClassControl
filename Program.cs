using System;
using System.Collections.Generic;
using Vehicles.Engine;
using Vehicles.Model;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Car 
            var tesla = new Car("Tesla", "Model X", "Белая",
                              new ElectricEngine(5000, 420),
                              CarClass.Sport);

            var toyota = new Car("Toyota", "Supra", "Красный",
                              new InternalCombustionEngine(Fuel.Gasoline, 320, 620, 8, 32),
                              CarClass.Sport);
            #endregion

            #region Airplane
            var airobus = new Airplan("Аиробус", "СУ-5", "Белый", 500, 12000, 200,
                                      new TurbojetEngine(Fuel.Kerosene, 4000, 820, 50, 200),
                                      Appointment.Passenger);

            var military = new Airplan("Avie", "BH-33", "Черный", 2, 16000, 400,
                                      new TurbojetEngine(Fuel.Kerosene, 2000, 1200, 20, 200),
                                      Appointment.Military);
            #endregion

            #region Ship
            var ship = new SeaShip("CMA", "CSG", "Синий", "Antoine de Saint Exupery", 50000, 20,
                                   new InternalCombustionEngine(Fuel.Diesel, 5000, 2000, 100, 50),
                                   Appointment.Freight);
            #endregion

            #region Train
            var train = new Train("Локомотив", "ТЭЗ", "Красный", 5000, 2,
                                new InternalCombustionEngine(Fuel.Diesel, 4000, 2000, 100, 40),
                                Appointment.Passenger);
            #endregion

            var listTransopr = new List<Transport>();

            listTransopr.Add(tesla);
            listTransopr.Add(toyota);
            listTransopr.Add(airobus);
            listTransopr.Add(military);
            listTransopr.Add(ship);
            listTransopr.Add(train);

            foreach (var item in listTransopr)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }



        }
    }
}
