using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._4
{
    /// <summary>
    /// Задача 6. Определить статический метод void Numbers (int n), который выводит на экран четные числа от 2 до числа n. Используя этот метод, вывести на экран четные числа:
    /// </summary>
    class Program
    {
        static void Numbers(int n)
        {
            for (int i = 2; i<=n; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        //public static void Output(int result)
        //{
        //    Console.WriteLine(result);
        //}
        static void Main(string[] args)
        {
            int n = Input("n = ");
            Numbers(n);
            //int result = Numbers(n);
            //Output(result);
            Console.Read();
        }
    }
}
