using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsLib
{
    /// <summary>
    /// All possible genders
    /// </summary>
    public enum Gender
    {
        Male , 
        Female ,
        Unknown
    }
    /// <summary>
    /// Class for an animal
    /// </summary>
    public abstract class Animal
    {

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public Gender Gender { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <param name="name">The name.</param>
        /// <param name="gender">The gender.</param>
        public Animal(double weight, string name , Gender gender)
        {
            Weight = weight;
            Name = name;
            Gender = gender;
        }

        /// <summary>
        /// Makes the sound.
        /// </summary>
        /// <returns></returns>
        public abstract string MakeSound();

    }
}
