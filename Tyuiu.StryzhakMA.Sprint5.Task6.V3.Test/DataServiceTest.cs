using Tyuiu.StryzhakMA.Sprint5.Task6.V3.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string folder = "C:\\DataSprint5";
            string name = "InPutDataFileTask6V3.txt";
            string path = Path.Combine(folder, name);
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(21, res);
        }
    }
}
