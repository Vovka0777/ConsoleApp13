using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13._4
{
    /// <summary>
    /// Задача 4. Определить статический метод int Seconds (int h, int m, int s), 
    /// который принимает три целых аргумента (часы h, минуты m и секунды s) и возвращает количество секунд, 
    /// прошедших с начала дня. Используя этот метод, вычислить количество секунд, прошедших с начала дня.
    /// а) 0 ч 40 мин 20 с;
    /// б) 3 ч 10 мин 50 с.
    /// </summary>
    class Program
    {
        static int Seconds (int h, int m, int s)
        {
            return h * 3600 + m * 60 + s;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Output(int result)
        {
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            int s = Input("s = ");
            int m = Input("m = ");
            int h = Input("h = ");
            Seconds(h, m, s);
            int result = Seconds(h, s, m);
            Output(result);
            Console.Read();
        }
    }
}
