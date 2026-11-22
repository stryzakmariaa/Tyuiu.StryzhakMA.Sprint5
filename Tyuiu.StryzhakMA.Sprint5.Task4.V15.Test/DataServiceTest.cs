using Tyuiu.StryzhakMA.Sprint5.Task4.V15.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";
            double expected = 5.878;
            double actual = ds.LoadFromDataFile(path);
            Assert.AreEqual(expected, actual);
        }
    }
}
