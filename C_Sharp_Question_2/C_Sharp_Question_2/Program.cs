using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION TWO
            var myArray = new string[7] { "NIGER", "BENUE", "ZAMFARA", "SOKOTO", "IMO", "KWARA", "BAYELSA" };

            var orderedArray = myArray.OrderBy(state => state.Length)
                .ThenBy(len => len.First())
                .ToList();

            foreach (var item in orderedArray)
            {
                Console.WriteLine($"{item}");
            }
            Console.ReadKey();
        }
    }
}
