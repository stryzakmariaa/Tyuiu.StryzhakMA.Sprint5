using System.IO;
using Tyuiu.StryzhakMA.Sprint5.Task5.V13.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task5.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask5V13.txt";

            double expected = -1; 
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
