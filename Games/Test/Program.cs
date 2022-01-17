using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Age = 5;
            animal.Name = "Franek";
            //animal.Information();
            
        }
    }
    interface IAnimal
    {

        int Age { get; set; }
        string Name { get; set; }
        //void Information()
        //{
        //    Console.WriteLine($"This entity have {Age} years old and he's name is {Name}");
        //}
        void Information();
    }

    interface IMechanical
    {

        int Old { get; set; }
        string Problem { get; set; }
        void Data()
        {
            Console.WriteLine($"This entity have {Old} years old and he's name is {Problem}");
        }

    }
    class Animal : IAnimal, IMechanical
    {
        private int age;
        private string name;

        public int Age
        {
            get => age;
            set
            {
                if (value < 1)
                {
                    age = 1;
                }
                else
                {
                    age = value;
                }
            }
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int Old {get; set; }
        public string Problem { get; set ; }

        public void Information()
        {
            Console.WriteLine($"This entity have {Age} years old and he's name is {Name}");
            var kaczka = new Kaczka(new SzybkieLatanie());
        }
    }

    interface ILatanie
    {
        
        void Lec();
    }
    class SzybkieLatanie : ILatanie
    {
        public void Lec()
        {
            throw new NotImplementedException();
        }
    }
    class PowolneLatanie : ILatanie
    {
        public void Lec()
        {
            throw new NotImplementedException();
        }
    }
    class Kaczka
    {
        private ILatanie latanie;

        public Kaczka(ILatanie latanie)
        {
            this.latanie = latanie;
        }
    }
}
