using Tyuiu.StryzhakMA.Sprint5.Task3.V30.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;

            string expected = "0,722";
            string actual = ds.SaveToFileTextData(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
