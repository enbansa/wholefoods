using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            var Name = "Amazon";
            for (int i = Name.Length - 1; i > 0; i--)
            {
                char Character = Name[i];
                Console.Write(Character);
            }
            Console.WriteLine();

        }
    }
}
