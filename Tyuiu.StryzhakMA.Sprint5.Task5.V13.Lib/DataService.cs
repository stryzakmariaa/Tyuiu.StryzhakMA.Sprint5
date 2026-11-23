using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            text = text.Replace('.', ',');
            string[] parts = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;
            foreach (string part in parts)
            {
                double number = Convert.ToDouble(part);
                if (number >= -1.5 && number <= 1.5)
                {
                    sum = sum + number;
                    count = count + 1;
                }
            }

            if (count == 0) return 0;
            double result = sum / count;
            return Math.Round(result, 3);
        }
    }
}
