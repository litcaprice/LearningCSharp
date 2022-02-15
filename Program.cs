using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[20];
            Random rand = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(-100, 100);
                Console.Write(array1[i] + " ");

            }
            Console.Read();




        }
    }
}