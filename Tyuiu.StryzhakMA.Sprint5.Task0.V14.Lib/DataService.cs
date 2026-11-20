using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task0.V14.Lib
{
    public class DataService : ISprint5Task0V14
    {
        public string SaveToFileTextData(int x)
        {
            double y = (4 * Math.Pow(x, 3)) / (Math.Pow(x, 3) - 1);
            y = Math.Round(y, 3);
            string path = Path.Combine(Path.GetTempPath(),"OutPutFileTask0.txt");
            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}
