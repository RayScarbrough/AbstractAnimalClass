using System;
using System.Data.Common;
namespace AbstractAnimals
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        public abstract string Color { get; set; }
        public abstract double Weight { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class AbstractAnimal
    {
        class Cat : Animal
        {
            public override string Name { get; set; }
            public override string Color { get; set; }
            public override double Weight { get; set; }

            public Cat()
            {
                Name = "";
                Color = "";
                Weight = 0.0;
            }
            public Cat(string name, string color, double weight)
            {
                Name = name;
                Color = color;
                Weight = weight;
            }
            public override string Describe()
            {
                Console.WriteLine();
                return "CATS!"+"\nName: " + Name + "\nColor: " + Color + "\nWeight: " + Weight;
            }

        }
        static void Main(string[] args)
        {
            Cat Pedro = new Cat("Pedro", "orange", 13);
            {
                Console.WriteLine(Pedro.Describe());
            }

            Cat PaPa = new Cat();
            {
                PaPa.Name = "PaPa";
                PaPa.Color = " White and Black";
                PaPa.Weight = 16;
                Console.WriteLine(PaPa.Describe());
            }
        }
    }
}
