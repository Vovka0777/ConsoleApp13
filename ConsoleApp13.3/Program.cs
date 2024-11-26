using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._2
{
    class Program
    {
        /// <summary>
        /// Задача 3. Найти s=min(a, b) + min(c, d), используя вспомогательные функции (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// <param name="message"></param>
        /// <returns></returns>
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static int Min(int x, int y)
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
            int c = Input("c = ");
            int d = Input("d = ");
            int result = Min(x, y) + Min(c, d);
            Output(result);
            Console.Read();
        }
    }
}
