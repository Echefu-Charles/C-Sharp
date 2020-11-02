using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION THREE

            Console.WriteLine("Enter string: ");
            string stringValue = Console.ReadLine();

            if (stringValue.Length <= 1)
            {
                Console.WriteLine("New String is : " + stringValue);
                Console.ReadKey();
            }
            else
            {

                var first = stringValue.First();
                var last = stringValue.Last();

                var remString = stringValue.Substring(1, (stringValue.Length - 2));
                var newStringValue = $"{last}{remString}{first}";

                Console.WriteLine("New String is : " + newStringValue);
                Console.ReadKey();
            }
        }
    }
}
