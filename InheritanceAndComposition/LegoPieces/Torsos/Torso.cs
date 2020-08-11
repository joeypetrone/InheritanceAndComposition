using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    abstract class Torso
    {
        //properties
        public ArmType ArmType { get; set; }
        public string Clothing { get; protected set; }
        public string Accessory { get; set; }
        public Sex Sex { get; set; }

        //methods
        public void Wave()
        {
            Console.WriteLine($"Waves hello with their {ArmType} arm.");
        }

        public void PickUp(string heavyObject)
        {
            if (ArmType == ArmType.Strong)
            {
                Console.WriteLine($"I used my strong arms to pick up the {heavyObject}.");
            }
            else
            {
                Console.WriteLine($"My {ArmType} arms cannot pick up {heavyObject}.");
            }
        }

        protected bool IsStrong()
        {
            return ArmType == ArmType.Strong;
        }

    }

    enum ArmType
    {
        Skinny,
        Strong,
        Baby,
        Dinosaur
    }

    enum Sex
    {
        Male,
        Female,
        Other
    }
}
