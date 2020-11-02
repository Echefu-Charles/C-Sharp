using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION FOUR
            var vowelList = new List<char>()
            {
                'A', 'E', 'I', 'O', 'U'
            };
            Console.WriteLine("Enter a single alphabet : ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            if (vowelList.Contains(char.ToUpper(alphabet)))
            {
                Console.WriteLine("Alphabet entered is a vowel");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Alphabet entered is a consonant");
                Console.ReadKey();
            }
        }
    }
}
