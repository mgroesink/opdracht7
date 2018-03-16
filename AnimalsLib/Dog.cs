using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLib
{
    public class Dog : Animal
    {

        // gender is een optionele parameter.
        // als niets wordt opgegeven bij het instantiëren
        // wordt als geslacht man gekozen
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <param name="name">The name.</param>
        /// <param name="gender">The gender.</param>
        public Dog(double weight , string name , Gender gender = Gender.Male):
            base (weight , name , gender)
        { }

        /// <summary>
        /// Makes the sound.
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            return "Woof";
        }


    }
}
