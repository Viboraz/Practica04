using System;
using System.Collections.Generic;
using System.Text;

namespace Practica04
{
    class Person
    {
        // four fields:
        private string name;
        private string surname;
        private int age;
        private int height;
        private int weight;

        // Constructor that takes two argument:
        public Person(string name, string surname, int age)
        {
            this.name = name;
            this.age = age;
            this.surname = surname;
            this.weight = 0;
            this.height = 0;
        }

        // methods, getters and setters:
        public void printPerson()
        {
            Console.WriteLine("Nombre: " + this.name + " " + this.surname + " / Edad: " + this.age );
        }
        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public String GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public String GetSurname()
        {
            return this.surname;
        }

        public void SetSurname(string surname)
        {
            this.name = surname;
        }
        public int GetHeight()
        {
            return this.height;
        }

        public void SetHeight(int height)
        {
            this.age = height;
        }
        public int GetWeight()
        {
            return this.weight;
        }

        public void SetWeight(int weight)
        {
            this.age = weight;
        }
    }
}
