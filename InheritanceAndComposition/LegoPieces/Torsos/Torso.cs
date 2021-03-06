﻿using System;
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

        //fields
        static int _numberOfItemsPickedUp = 0;

        //methods
        public virtual void Wave()
        {
            Console.WriteLine($"Waves hello with their {ArmType} arm.");
        }

        //not virtual or abstract, this behavior is always the same.
        public void PickUp(string heavyObject)
        {
            if (IsStrong())
            {
                Console.WriteLine($"I used my strong arms to pick up the {heavyObject}.");
                _numberOfItemsPickedUp++;
            }
            else
            {
                Console.WriteLine($"My {ArmType} arms cannot pick up {heavyObject}.");
            }
        }

        //virtual protected member being overriden in *some* classes, not required
        //virtual can be overriden, but has default method
        //protected virtual bool IsStrong()
        //use virtual when there is a reasonable default behavior, but it might change
        //{
        //    return ArmType == ArmType.Strong;
        //}

        //abstract method, must be overriden in every class that inherits from this class
        //this method must exist in every class that inherits
        //use abstract when there is no reasonable default behavior
        protected abstract bool IsStrong();

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
        Unknown,
        Male,
        Female,
        Other
    }
}
