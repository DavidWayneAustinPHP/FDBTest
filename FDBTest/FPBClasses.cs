using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDBTest
{
    class FPBClasses
    {
    }

    public class  DatainfoME : AddSomeNumbers
    {
        public int meme = 5;
        public int ffhhg = 6;

        public int addValues()
        {
            return meme + ffhhg;
        }

        public int addForeignValues(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    public class Pig : FDBInterfaces
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
}
