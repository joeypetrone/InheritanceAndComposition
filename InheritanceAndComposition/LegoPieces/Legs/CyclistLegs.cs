using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Legs
{
    class CyclistLegs : Legs 
    {
        //Cyclist constructor
        public CyclistLegs() : base("Biker shorts", "Cyclist shoes", true)
        {

        }

        public override void Dance()
        {
            Console.WriteLine("Too busy biking to dance.");
        }
    }
}
