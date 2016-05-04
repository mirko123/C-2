using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Compare_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];
            string isEquals = "Equal";

            for (int i = 0; i < n; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    isEquals = "Not equal";
                    break;
                }
            }
            Console.WriteLine(isEquals);
        }
    }
}
