using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class AstronautHead
    {
        //auto properties
        public bool HasHelmet { get; set; } = true;
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }
        public bool HasFreckles { get; set; }

        public void Greet()
        {
            Console.WriteLine("Major Tom to Ground Control....");
        }

        public void Observe()
        {
            Console.WriteLine("The Astronaut sees everything all at once. Across time.");
        }
    }
}
