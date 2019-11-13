using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your name");
                var name = Console.ReadLine();
                Console.WriteLine("Hello " + name + " Welcome to my name");
                Console.WriteLine( "Try Again? If yes enter y");
                var response = Console.ReadLine();
                if (response != "y")
                    break;





            }
            


        }

    }
}
