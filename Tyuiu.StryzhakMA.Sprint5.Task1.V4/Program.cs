using Tyuiu.StryzhakMA.Sprint5.Task1.V4.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task1.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант 4                                                               *");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = cos(x)/(x+1) - cos(x)*1.3 + 3x.                     *");
            Console.WriteLine("* Произвести табулирование на [-5; 5] с шагом 1.                          *");
            Console.WriteLine("* При делении на ноль вернуть 0. Результат сохранить в                    *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу.                     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("   x   |   F(x)   ");
            Console.WriteLine("------------------");

            string[] lines = System.IO.File.ReadAllLines(res);
            foreach (string line in lines)
            {
                Console.WriteLine("  " + line);
            }
            Console.WriteLine("------------------");

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.ReadKey();
        }
    }
}
