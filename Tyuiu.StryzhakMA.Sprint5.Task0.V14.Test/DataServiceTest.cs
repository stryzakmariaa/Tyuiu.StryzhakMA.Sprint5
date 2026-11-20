using System.IO;
using Tyuiu.StryzhakMA.Sprint5.Task0.V14.Lib;

namespace Tyuiu.StryzhakMA.Sprint5.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            Assert.IsTrue(Path.Exists(path));
            Assert.AreEqual("4,154", File.ReadAllText(path));
        }
    }
}
