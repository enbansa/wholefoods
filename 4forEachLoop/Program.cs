using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4forEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[3] { 10, 20, 20 };
            foreach (int eachInt in intArray)
            {
                Console.WriteLine(eachInt);
            }

            string[] stringArray = new string[3] { "one", "two", "three" };
            foreach (string eachString in stringArray)
            {
                Console.WriteLine(eachString);
            }
        }  
    }
}
