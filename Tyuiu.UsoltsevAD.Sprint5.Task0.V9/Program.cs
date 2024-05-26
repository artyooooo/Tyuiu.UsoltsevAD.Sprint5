using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.UsoltsevAD.Sprint5.Task0.V9.Lib;
namespace Tyuiu.UsoltsevAD.Sprint5.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3;
            Console.Title = "Спринт #5 | Выполнил: Усольцев А.Д. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Усольцев Артём Денисович | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дано выражение. Вычислить его значение при x = 3, результат сохранить   *");
            Console.WriteLine("* в текстовый файл 'OutPutFileTask0.txt' и вывести на консоль.            *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* y(x) = x^3 / (x^2 - 1)                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Успешно создан!");
            Console.ReadKey();
        }
    }
}
