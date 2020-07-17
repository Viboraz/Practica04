using System;
using System.Collections.Generic;
using System.Text;

namespace Practica04
{
    class Car
    {
        private int year;
        private string brand;
        private string fuel;
        private int speed;

        public Car()
        {
            this.year = 2012;
            this.brand = "Lexus";
            this.fuel = "Gasolina";
            this.speed = 256;
        }

        public Car(string brand, int year, string fuel, int speed)
        {
            this.year = year;
            this.brand = brand;
            this.fuel = fuel;
            this.speed = speed;
        }
        public void printCar()
        {
            Console.WriteLine("Marca: " + this.brand + " / Año: " + this.year + " / Combustible: " + this.fuel + " / Velocidad: " + this.speed);
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public string Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }
    }
}
