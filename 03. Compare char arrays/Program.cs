using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            if (str1.CompareTo(str2) > 0)
            {
                Console.WriteLine(">");
            }
            else if (str1.CompareTo(str2) == 0)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}
