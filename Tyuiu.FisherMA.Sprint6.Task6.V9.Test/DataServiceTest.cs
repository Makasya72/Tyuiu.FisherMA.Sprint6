using Tyuiu.FisherMA.Sprint6.Task6.V9.Lib;
namespace Tyuiu.FisherMA.Sprint6.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFile()
        {
            string[] paths = { @"c:\Users", "Äìèòðèé", "source", "repos", "Tyuiu.SinitsinDV.Sprint6", "Tyuiu.SinitsinDV.Sprint6.Task6.V9", "bin", "Debug", "InPutFileTask6V9.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}