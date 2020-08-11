using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class AstronautHead : Head
    {
        //auto properties
        public bool HasHelmet { get; set; } = true;
        public bool HasFreckles { get; set; }

        public override void Greet()
        {
            Console.WriteLine("Major Tom to Ground Control....");
        }

        public void Observe()
        {
            Console.WriteLine("The Astronaut sees everything all at once. Across time.");
        }
    }
}
