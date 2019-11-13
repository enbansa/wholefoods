using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enter a number
            //if input is 1 or ,print one or two
            //if input is 3, print three
            //if input is 4, print four`
            //if input is other number,print other

            Console.WriteLine("Enter a number");
            String stringNum = Console.ReadLine();
            int num = Convert.ToInt32(stringNum);
         
            switch (num)
            {
                case 1:
                    Console.WriteLine("One");
                    break;


                case 2:
                    Console.WriteLine("Two");
                    break;

                case 3:
                    Console.WriteLine("Three");
                    break;

                case 4:
                    Console.WriteLine("Four");
                    break;



                default:
                    Console.WriteLine("Others");
                    break;

            }
        }
    }
}
