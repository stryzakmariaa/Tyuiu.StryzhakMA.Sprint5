using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task4.V15.Lib
{
    public class DataService : ISprint5Task4V15
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path).Trim();
            text = text.Replace('.', ',');
            double x = Convert.ToDouble(text);
            double y = Math.Sin(x) + (Math.Pow(x, 2) / 2.0);
            double res = Math.Round(y, 3);
            return res;
        }
    }
}
