using AnimalsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht7
{
    class Program
    {
        private static List<Animal> animals = new List<Animal>();
        static void Main(string[] args)
        {
            animals.Add(new Chicken(4.5, "Calimero" , Gender.Female));
            animals.Add(new Pig(58, "Miss Piggy"));
            animals.Add(new Dog(28, "Bo", Gender.Female));
            animals.Add(new Dog(name: "Simba", weight: 32));

            Sing();
        }

        /// <summary>
        /// Let all the animals present themselves.
        /// </summary>
        private static void Sing()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("Name: " + animal.Name + "\n" +
                    animal.MakeSound());
            }
        }
    }
}
