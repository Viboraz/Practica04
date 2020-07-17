using System;

namespace Practica04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Classes and Objects!");

            var driver01 = new Person("José", "García López", 24);
            var driver02 = new Person("Rafael", "Quero Gallego", 42);
            var driver03 = new Person("Vicente", "Pérez Soto", 26);

            Person[] drivers = { driver01, driver02, driver03 };

            var car01 = new Car("Toyota", 2019, "Gasolina", 200);
            var car02 = new Car("Peugeot", 2018, "Gasolina", 210);
            var car03 = new Car("Audi", 2020, "Gasolina", 240);

            Car[] cars = { car01, car02, car03 };

            Console.WriteLine("Drivers list");
            foreach (Person driverslist in drivers)
            {
                driverslist.printPerson();
            }


            Console.WriteLine("Cars list");
            foreach (Car carslist in cars)
            {
                carslist.printCar();
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
