using System;
using System.Threading;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var cardinal = new Bird();
            cardinal.BeakSize = "Small";
            cardinal.BuildNest = true;
            cardinal.FeatherColor = "red";
            cardinal.DoesSing = true;

            Console.WriteLine($"Cardinals are typically {cardinal.FeatherColor}, with a {cardinal.BeakSize} beak.");
            Thread.Sleep(1500);

            Console.WriteLine("Couple True or False, hit any key to continue:");
            Console.ReadLine();

            Console.WriteLine("Cardinal's build nests");
            Console.WriteLine($"{cardinal.BuildNest}");

            Console.WriteLine("Cardinal's like to sing.");
            Console.WriteLine($"{cardinal.DoesSing}");

            Thread.Sleep(1000);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var breadedDragon = new Reptile();
            breadedDragon.ScaleColor = "yellowish brown";
            breadedDragon.SizeOfTail = "typically same size as its body";
            breadedDragon.LivingEnviorment = "sandy and hot";
            breadedDragon.DoesItSwim = true;


            Console.WriteLine("Now lets talk about Reptiles, I personally like Breaded Dragons, want to know the typical color of a breaded dragon is?");
            Console.ReadLine();

            Console.WriteLine($"Breaded Dragons are typically {breadedDragon.ScaleColor} and they love to live in {breadedDragon.LivingEnviorment} environments.");
            Console.WriteLine($"Their tail is {breadedDragon.SizeOfTail} and some people believe they can't swim, but it is{breadedDragon.DoesItSwim}");





        }
    }
}
