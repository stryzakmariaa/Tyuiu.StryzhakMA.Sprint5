using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task2.V26.Lib
{
    public class DataService : ISprint5Task2V26
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            string resultText = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int value = matrix[i, j];

                    if (value > 0)
                    {
                        value = 1;
                    }
                    else
                    {
                        value = 0;
                    }

                    resultText = resultText + value;

                    if (j < 2)
                    {
                        resultText = resultText + ";";
                    }
                }

                resultText = resultText + "\n";
            }

            File.WriteAllText(filePath, resultText);

            return filePath;
        }
    }
}
