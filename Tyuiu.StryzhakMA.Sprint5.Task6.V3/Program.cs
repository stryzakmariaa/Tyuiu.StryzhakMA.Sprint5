using System;
using System.IO;
using Tyuiu.StryzhakMA.Sprint5.Task6.V3.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task6.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                           ");
            Console.WriteLine("* Задание #6                                                               "); 
            Console.WriteLine("* Вариант #3                                                               "); 
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                   ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            string folder = "C:\\DataSprint5";
            string name = "InPutDataFileTask6V3.txt";
            string path = Path.Combine(folder, name);

            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");

            int res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
