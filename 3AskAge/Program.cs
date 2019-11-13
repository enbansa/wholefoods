using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3AskAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            String age = Console.ReadLine();
            String response = "You are " + age + " years old";
            Console.WriteLine(response);
            Console.ReadLine();

        }
    }
}
