using Tyuiu.StryzhakMA.Sprint5.Task7.V13.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task7.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Стрыжак М. А. | АСОиУб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                                ");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  ");
            Console.WriteLine("* Задание #7                                                               ");
            Console.WriteLine("* Вариант #13                                                              ");
            Console.WriteLine("* Выполнила: Стрыжак М. А. | АСОиУб-26-1                                   ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            string folder = "C:\\DataSprint5";
            string fileName = "InPutDataFileTask7V13.txt";
            string inputPath = Path.Combine(folder, fileName);

            Console.WriteLine("Исходные данные находятся в файле: " + inputPath);
            Console.WriteLine();

            Console.WriteLine("*******************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:");
            Console.WriteLine("*******************************************************");

            string outputPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine("Результат сохранен в новый файл: " + outputPath);

            Console.ReadKey();
        }
    }
}
