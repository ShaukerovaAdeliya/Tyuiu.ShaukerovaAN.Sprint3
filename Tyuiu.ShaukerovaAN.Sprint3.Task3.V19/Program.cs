using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShaukerovaAN.Sprint3.Task3.V19.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint3.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Шаукерова А.Н. | ИСТНб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт#3                                                                *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Шаукерова Аделия Нуржановна | ИСТНб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы x на цифру 2 в строке:            *");
            Console.WriteLine("* sxxrrg x vfrx                                                           *");
            Console.WriteLine("*                                                                         *");


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "sxxrrg x vfrx";
            char rpb = 'x';
            char rpc = '2';

            Console.WriteLine("Исходная строка = " + str);
            Console.WriteLine("Искомый символ = " + rpb);
            Console.WriteLine("Замена = " + rpc);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Выводимая строка = " + ds.ReplaceCharOnNum(str, rpb, rpc));

            Console.ReadKey();
        }
    }
}
