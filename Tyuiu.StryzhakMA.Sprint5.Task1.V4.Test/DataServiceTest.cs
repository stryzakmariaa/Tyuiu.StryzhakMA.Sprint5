using Tyuiu.StryzhakMA.Sprint5.Task1.V4.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task1.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int start = -5;
            int stop = 5;

            string path = ds.SaveToFileTextData(start, stop);

            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists);

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(11, lines.Length);
        }
    }
}
