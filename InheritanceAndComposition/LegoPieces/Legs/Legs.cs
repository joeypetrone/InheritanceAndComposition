using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    //Cannot be directly instantiated, just an idea of a class that has to be inherited from
    abstract class Legs
    {
        //Legs properties
        public string Clothing { get; }
        public string Shoes { get; }
        public bool IsShaved { get; }

        //Legs constructor
        protected Legs(string clothing, string shoes, bool isShaved)
        {
            Clothing = clothing;
            Shoes = shoes;
            IsShaved = isShaved;
        }

        //Legs methods
        public void Walk(int howManySteps)
        {
            Console.WriteLine($"The legs wearing {Clothing} walked {howManySteps} steps in {Shoes}.");
        }

        public void Kick()
        {
            Console.WriteLine("The legs kicked vigorously.");
        }

        //all classes that inherit must create an override
        public abstract void Dance();
    }
}
