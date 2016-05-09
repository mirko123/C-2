using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Maximal_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxLength = 0;
            int currentLength = 1;

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int lastNum = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (lastNum == arr[i])
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    lastNum = arr[i];
                    currentLength = 1;
                }
            }
            Console.WriteLine(maxLength);
        }
    }
}
