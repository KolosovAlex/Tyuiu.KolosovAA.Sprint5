using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BubenkoLG.Sprint5.Task1.V28.Lib;

namespace Tyuiu.BubenkoLG.Sprint5.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Колосов А А | ПКТБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл.                 ");
            Console.WriteLine("* Задание #1                                                               ");
            Console.WriteLine("* Вариант #28                                                              ");
            Console.WriteLine("* Выполнила: Колосов А А | ПКТБ-25-1                                       ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить     ");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.               ");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                  ");
            Console.WriteLine("*          cos(x)                                                          ");
            Console.WriteLine("* F(x) = --------- - sin(x) * 12x + 2                                      ");
            Console.WriteLine("*         x - 0,7                                                          ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("* Начало шага = " + startValue);
            Console.WriteLine("* Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.WriteLine("Таблица:");
            using StreamReader reader = new(res);
            string text = reader.ReadToEnd();
            Console.WriteLine(text);



            Console.ReadKey();
        }
    }
}