using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[6] { 1, 2, 8, 6, 5, 3 };
            int temp;

            //traverse 0 to array length
            for (int i = 0; i < intArray.Length; i++)
            {


                //traverse i+1 to array length
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    //compare array element with all next element
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }

            }
            Console.Write("order form:");
                foreach (int value in intArray)
                    {
                        Console.Write(value + " ");
                    }

            Console.WriteLine();

            int max = intArray[0];
            for (int index = 0; index < intArray.Length; index++)
            {
                if (intArray[index] > max) max = intArray[index];
            }
            Console.WriteLine("Maximum number is: " + max);

            Console.WriteLine();

            int min = intArray[0];
            for (int index = 0; index < intArray.Length; index++)
            {
                if (intArray[index] < min) max = intArray[index];
            }
            Console.WriteLine("Minimum number is: " + min);

            Console.WriteLine();

            int sum = 0;
            for (int index = 0; index < intArray.Length; index++)
            {
                sum += intArray[index];

            }
            Console.WriteLine("Sum is :" + sum);

            int temp1 = 0;
        
            for (int i = 0; i <( intArray.Length/2); ++i)
            {
                temp1 = intArray[i];
                intArray[i] = intArray[intArray.Length - 1 - i];
                intArray[intArray.Length - 1 - i] = temp1;
            }
            Console.Write("Reverse form: "  );
            foreach (int value1 in intArray)
            {
                Console.Write( value1 + " ");
            }

            Console.WriteLine();
            Console.ReadLine();


                


        }
    }
}
