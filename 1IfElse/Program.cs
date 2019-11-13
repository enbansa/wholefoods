using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //get age from user
            //if age is less than 40, print you are young
            //if age is more or equal to 40 and less than and equal to 50, print you are young
            // if age is more than 50, print you are not that old
            Console.WriteLine("Please Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age<40)
            {
                Console.WriteLine("You are very young");

            }
            else if(age>=40 && age<=50)
            {
                Console.WriteLine("You are young");

            }
            else if (age>50)
            {
                Console.WriteLine("You are not that old");
            }

            Console.ReadLine();


           
        }
    }
}
