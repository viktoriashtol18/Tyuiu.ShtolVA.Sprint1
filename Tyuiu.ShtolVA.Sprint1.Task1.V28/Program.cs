﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShtolVA.Sprint1.Task1.V28.Lib;

namespace Tyuiu.ShtolVA.Sprint1.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Штоль В.А | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #1 ");
            Console.WriteLine(" Тема: Базовые навыки работы в С# ");
            Console.WriteLine(" Задание #1 ");
            Console.WriteLine(" Вариант #28 ");
            Console.WriteLine(" Выполнила: Штоль Виктория Алексеевна | ИИПб-23-3 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: *");
            Console.WriteLine(" Написать программу, которая запрашивает у пользователя исходные данные, ");
            Console.WriteLine("* вычисляет результат по формуле (x*2)/(1+x) и печатает его на экране. *");
            Console.WriteLine("* *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: ");
            Console.WriteLine("***************************************************************************");
            double x;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
