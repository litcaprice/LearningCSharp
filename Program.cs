using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[20];
            Random rand = new Random();
            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(-100, 101);
                Console.Write(array1[i] + " ");
                    sum = sum + array1[i];
            }
            int average = sum / array1.Length;
            Console.WriteLine("Sum: " + sum);            // вывод суммы
            Console.WriteLine("Max: " + array1.Max());   // вывод максимального числа
            Console.WriteLine("Min: " + array1.Min());   // вывод минимального числа
            Console.WriteLine("Average: " + average);
            Console.ReadKey();


        }
    }
}
