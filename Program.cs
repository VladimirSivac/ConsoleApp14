using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    /// <summary>
    /// С использованием цветового оформления консоли: а) вывести на экран горизонтальную строку из 18 символов; б) вывести на экран вертикальную строку из 25 символов.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
           // Настройки консоли
           Console.Title = "Вывод горизонтальной и вертикальной строк";
           Console.BackgroundColor = ConsoleColor.Cyan;
           Console.ForegroundColor = ConsoleColor.Red;
           
           // Вывод строк
           HorizontalLine();
           VerticalLine();
        }

        static void HorizontalLine()
        {
            string line = "x";
            for (int i = 1; i <= 18; i++)
            {
                Console.Write(line);
            }
        }
        
        static void VerticalLine()
        {
            string line = "x";
            for (int i = 1; i <= 25; i++)
            {
                Console.WriteLine(line);
            }
        }
    }
}