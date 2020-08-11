using InheritanceAndComposition.LegoPieces.Heads;
using System;

namespace InheritanceAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Head head = new AstronautHead();

            head.EyeColor = EyeColor.Blue;

            head.Greet();
        }
    }
}
