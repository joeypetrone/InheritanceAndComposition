using System;

namespace InheritanceAndComposition.LegoPieces.Heads
{
    class PirateHead
    {
        //auto properties
        public bool HasPatch { get; set; }
        public string FacialHair { get; set; }
        public HairColor HairColor { get; set; }
        public EyeColor EyeColor { get; set; }

        public void Sing()
        {
            Console.WriteLine($"The {HairColor} pirate sang 'Yo ho ho and a bottle of rum' out of tune.");
        }

        public void Laugh()
        {
            Console.WriteLine("Har Har Har.");
        }

        public void Greet()
        {
            Console.WriteLine("AAAAAAAAAARRRRRRGGGGGGGGGGGHHHHH");
        }
    }
}
