using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    /// <summary>
    /// Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("Введите n: ");
            Func(n);
        }

        static int Input(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static void Func(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }   
        }
    }
}