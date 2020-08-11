using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class CowgirlHead
    {
        //auto properties
        public EyeColor EyeColor { get; set; }
        public HairColor HairColor { get; set; }
        public bool HasHat { get; set; }
        public LipstickColor LipstickColor { get; set; }

        public void HairFlip()
        {
            Console.WriteLine($"The cowgirl flips her {HairColor} hair. She doesn't even care.");
        }

        public void Greet()
        {
            Console.WriteLine("Howdy!");
        }

        public void Eat()
        {
            Console.WriteLine("The cowgirl eats her beans from a tin can.");
        }

    }
}
