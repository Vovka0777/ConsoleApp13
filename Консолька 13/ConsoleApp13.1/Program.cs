using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._1
{
    class Program
    {
        /// <summary>
        /// Задача 1. Найти минимальную величину из двух целых переменных a, b, используя вспомогательные методы (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        static int Input (string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int x,int y)
        {
            return x < y ? x : y;
        }
        public static void Output(int result)
        {
           Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            int x = Input("x = ");
            int y = Input("y = ");
            int result = Min(x,y);
            Output(result);
            Console.Read();
        }
    }
}
