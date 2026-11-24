using Tyuiu.StryzhakMA.Sprint5.Task7.V13.Lib;
namespace Tyuiu.StryzhakMA.Sprint5.Task7.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string folder = "C:\\DataSprint5";
            string fileName = "InPutDataFileTask7V13.txt";
            string inputPath = Path.Combine(folder, fileName);
            string outputPath = ds.LoadDataAndSave(inputPath);
            Assert.IsTrue(File.Exists(outputPath));

            string savedText = File.ReadAllText(outputPath);

            string expectedText = "H, Мир! Это I M F P."; 

            Assert.AreEqual(expectedText, savedText);
        }
    }
}
