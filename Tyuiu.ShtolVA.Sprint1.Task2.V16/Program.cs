using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PaulikKV.Sprint1.Task2.V16.Lib;

namespace Tyuiu.PaulikKV.Sprint1.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ :                                                       ");
            Console.WriteLine("**");

            int x;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**");
            Console.WriteLine(" Результат :                                                             ");
            Console.WriteLine("**");
            Console.WriteLine("Периметр круга = " + ds.CalculatePerimetrCircle(x));
            Console.ReadLine();

        }
    }
}
