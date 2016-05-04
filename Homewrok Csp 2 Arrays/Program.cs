using System;

public class Arrays
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(i * 5);
        }
    }
}