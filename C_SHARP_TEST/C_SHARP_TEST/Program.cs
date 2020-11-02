using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION ONE
            Console.WriteLine("Enter string: ");
            string stringValue = Console.ReadLine();

            var charList = stringValue.GroupBy(b => b).ToList();

            foreach (var character in charList)
            {
                Console.WriteLine($"Character {character.Key}: {character.Count()} times");
            }
            Console.ReadKey();

        }
    }
}
