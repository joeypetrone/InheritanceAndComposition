using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndComposition.LegoPieces.Torsos
{
    class NinjaTorso : Torso
    {
        //Ninja properties
        public string Weapon { get; set; }

        //Ninja constructor
        public NinjaTorso()
        {
            Clothing = "Black ninja-yoroi";
            Accessory = "Red cape";
            ArmType = ArmType.Strong;
            Sex = Sex.Unknown;
            Weapon = "Nunchaku";
        }

        //Ninja methods
        public override void Wave()
        {
            Console.WriteLine($"The ninja torso waves its {ArmType} arms silently to get your attention.");
        }

        protected override bool IsStrong()
        {
            return true;
        }
    }
}
