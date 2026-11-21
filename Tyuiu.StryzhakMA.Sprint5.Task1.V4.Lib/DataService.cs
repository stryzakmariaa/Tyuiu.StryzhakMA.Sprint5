
using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y;

                    if (x == -1)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;
                    }

                    y = Math.Round(y, 2);

                    writer.WriteLine(x + " " + y);
                }
            }

            return path;
        }
    }
}
