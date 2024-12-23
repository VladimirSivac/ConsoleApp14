using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Hello();
        }

        static void Hello()
        {
            // Цикл с параметром
            /*for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Привет!");
            }*/
            
            // Цикл с условием
            int n = 1;
            while (n <= 5)
            {
                Console.WriteLine("Привет!");
                n++;
            }
        }
    }
}