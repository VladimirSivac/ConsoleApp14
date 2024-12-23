using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    /// <summary>
    /// Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            
            // Цикл с предусловием
            /*while (n <= 10)
            {
                Console.WriteLine(n);
                n++;
            }*/
            
            // Цикл с постусловием
            /*do
            {
                Console.WriteLine(n);
                n++;
            } while (n <= 10);*/
            
            // Цикл с параметром
            /*for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/
            
        }
    }
}