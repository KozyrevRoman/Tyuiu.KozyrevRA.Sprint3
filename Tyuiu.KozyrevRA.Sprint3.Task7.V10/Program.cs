using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KozyrevRA.Sprint3.Task7.V10.Lib;
namespace Tyuiu.KozyrevRA.Sprint3.Task7.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Козырев Р. А. | СМАРТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Вложенные циклы                                                  *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Козырев Роман Артёмович | СМАРТБ-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец  отрезка = " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] res = ds.GetMassFunction(startValue,stopValue);
            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(X)  |");
            Console.WriteLine("+---------+---------+");
            for (int i = startValue; i <= stopValue; i++)
            {
                Console.WriteLine("|{0, 5:d}    |{1, 7:f2}  |", i, res[i - startValue]);
            }
            Console.WriteLine("+---------+---------+");
            Console.ReadKey();
        }
    }
}