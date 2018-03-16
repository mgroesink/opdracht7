using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLib
{
    public class Chicken : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Chicken"/> class.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <param name="name">The name.</param>
        /// <param name="gender">The gender.</param>
        public Chicken(double weight, string name, Gender gender) : 
            base(weight, name,gender)
        {
        }

        /// <summary>
        /// Makes the sound.
        /// </summary>
        /// <returns></returns>
        public override string MakeSound()
        {
            return "Tok Tok Tok";
        }
    }
}
