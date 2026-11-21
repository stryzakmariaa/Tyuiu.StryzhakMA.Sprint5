using System.IO;
using Tyuiu.StryzhakMA.Sprint5.Task2.V26.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task2.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[,]
            {
                { 2, -3, -3 },
                { -8, 8, 0 },
                { -6, 1, 0 }
            };

            string res = ds.SaveToFileTextData(matrix);

            bool fileExists = File.Exists(res);
            Assert.IsTrue(fileExists);
        }
    }
}
