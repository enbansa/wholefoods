using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "defend the east wall of the castle";
            for (int index = 0; index < input.Length; index++)
            {
                char character = input[index];
                char shiftCharacter;
                if (character == ' ')//character==32
                {
                    shiftCharacter = character;
                }

                else
                {
                    shiftCharacter = Convert.ToChar(character + 1);
                }
                Console.Write(shiftCharacter);
            }
            Console.ReadLine();
        }
    }
}
