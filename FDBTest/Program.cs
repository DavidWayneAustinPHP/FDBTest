using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDBTest;

namespace FDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Completed pushing to Github");
            Console.WriteLine("More stuff");
            Pig myPig = new Pig();
            DatainfoME myTest = new DatainfoME();
            
            myPig.animalSound();

            Console.WriteLine(myTest.ffhhg + "and another" + myTest.meme);

            Console.WriteLine("Adding two values: " + myTest.addValues());

            Console.ReadKey();

        }
    }
}
