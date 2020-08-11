using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class Head
    {
        //auto properties        
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }

        //virtual allows a class that is inheriting "Head" to use override to specify it's own method for "Greet()" 
        public virtual void Greet()
        {
            Console.WriteLine("Hello!");
        }
    }
}
