using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDBTest;
u


namespace FDBTest
{
    class Program
    {
        interface IAnimal
            {
                void animalSound(); // interface method (does not have a body)
            }
    
        public class Pig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Completed pushing to Github");
            Console.WriteLine("More stuff");
            Pig myPig = new Pig();            


            myPig.animalSound();

            Console.ReadKey();

        }
    }
}
