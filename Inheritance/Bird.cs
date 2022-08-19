using System;
namespace Inheritance
{
    internal class Bird: Animal
    {
        // Done - Create a class Bird
        // Done- give this class 4 members that are specific to Bird
        // Done - Set this class to inherit from your Animal Class

   
       
        public Bird()
        {

        }

        public string FeatherColor { get; set; }
        public string BeakSize { get; set; }
        public bool DoesSing { get; set; }
        public bool BuildNest { get; set; }

    }
}

