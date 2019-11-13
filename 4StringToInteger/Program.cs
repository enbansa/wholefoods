using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            //getting an input from user and storing it to string variable named name
            string stringage = Console.ReadLine();
            int age = Convert.ToInt32(stringage);
            string response = "You will be " +( age+10) + " years old in 10 years";
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
