using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLib
{
    public class Pig: Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pig"/> class.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <param name="name">The name.</param>
        /// <param name="gender">The gender.</param>
        public Pig(double weight, string name , Gender gender = Gender.Female) : 
                base(weight, name , gender)
            {
            }

        /// <summary>
        /// Makes the sound.
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
            {
                return "Knor";
            }
        }
}
