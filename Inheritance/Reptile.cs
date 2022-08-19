using System;
namespace Inheritance
{
    internal class Reptile : Animal
    {
        // Done - Create a class Reptile
        // Done - give this class 4 members that are specific to Reptile
        // Done - Set this class to inherit from your Animal Class

        public Reptile()
        {
        }

        public string ScaleColor { get; set; }
        public string LivingEnviorment { get; set; }
        public bool DoesItSwim { get; set; }
        public string SizeOfTail { get; set; }

    }
}

