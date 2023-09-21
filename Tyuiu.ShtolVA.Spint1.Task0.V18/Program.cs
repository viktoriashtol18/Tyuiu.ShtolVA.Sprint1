using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolVA.Sprint1.Task0.V18.Lib;

namespace Tyuiu.ShtolVA.Sprint1.Task0.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Штоль В.А. | ИИПб-23-3";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #1 ");
            Console.WriteLine(" Тема: Базовые навыки работы в С# ");
            Console.WriteLine(" Задание #0 ");
            Console.WriteLine(" Вариант #18 ");
            Console.WriteLine(" Выполнила: Штоль Виктория Алексеевна | ИИПб-23-3 ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ: ");
            Console.WriteLine(" Написать  программу, которая вычисляет выражение 9 * (6 / 2 * 3) / 9 / 3 ");
            Console.WriteLine("  и печатает результат на экране ");
            Console.WriteLine(" ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine("");
            Console.WriteLine("* 9 * (6 / 2 * 3) / 9 / 3 ");
            Console.WriteLine("");
            Console.WriteLine("* РЕЗУЛЬТАТ: ");
            Console.WriteLine("");

            Console.WriteLine(ds.Calculate());

            Console.ReadKey();

        }
    }
}