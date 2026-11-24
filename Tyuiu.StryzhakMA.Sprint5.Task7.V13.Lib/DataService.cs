using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.StryzhakMA.Sprint5.Task7.V13.Lib
{
    public class DataService : ISprint5Task7V13
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);
            StringBuilder res = new StringBuilder();
            foreach (char c in content)
            {
                if (!(c >= 'a' && c <= 'z'))
                {
                    res.Append(c);
                }
            }
            string newPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V13.txt");
            File.WriteAllText(newPath, res.ToString());
            return newPath;
        }
    }
}
