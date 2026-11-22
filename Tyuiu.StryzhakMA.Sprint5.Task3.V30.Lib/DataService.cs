using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task3.V30.Lib
{
    public class DataService : ISprint5Task3V30
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Round((Math.Pow(x, 3) - 1) / (4 * Math.Pow(x, 2)), 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (FileStream fs = new FileStream(path, FileMode.Create))
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write(y); 
            }

            return y.ToString().Replace('.', ',');
        }
    }
}
