using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            //reverse sentence :"this is an Amazon"
            //hint split()
            Console.WriteLine("Enter a sentence");
            var sentence = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string[] split = sentence.Split(' ');
            for (int i = split.Length - 1; i >= 0; i--)
            {
                sb.Append(split[i]);
                sb.Append(" ");


            }
            Console.WriteLine(sb);
            Console.ReadLine();

           // Console.WriteLine(string.Join(" ", sentence.Split(' ').Reverse()));
        }

    }
}
