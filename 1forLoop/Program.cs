using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1forLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //simple for loop for int
            /*int[] intArray = new int[3] { 10, 20, 30 };
            for (int i = 0; i <intArray.Length; i++)
            {
                Console.WriteLine(intArray[i]);
            }
            //simple for loop for string
            string[] stringArray = new string[3] { "one", "two", "three" };
            for(int i=0; i <stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
            */

            /*for loop to print 
            *
            * *
            * * *
            * * * *
            * * * * *
            */

            /* for (int i = 0; i < 6; i++)
              {
                 for (int j = 0; j <i; j++)
                  {
                      Console.Write("*");
                  }
                  Console.WriteLine();
              }
              */

            /*for loop to print 
                     *
                   * *
                 * * *
               * * * * 
             * * * * *
            */

            /*int n = 5;
             for(int i=0; i<n; i++)
             {
                 for (int j = 0; j <=n- i; j++)
                 {
                     Console.Write(" ");

                 }
                     for (int k=0;k<=i;k++)
                     {
                         Console.Write("*");
                     }
                 Console.WriteLine();
             }*/

            var Name= "Amazon";
            for(int i=Name.Length-1;i>0;i--)
            {
                char Character = Name[i];
                Console.Write(Character);
            }
            Console.WriteLine();
           




        }

    }
}
