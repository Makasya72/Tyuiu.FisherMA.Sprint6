using Tyuiu.FisherMA.Sprint6.Task5.V10.Lib;
namespace Tyuiu.FisherMA.Sprint6.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V10.txt");
            DataService ds = new DataService();
            double[] resArray = ds.LoadFromDataFile(path);
            double[] waitArray = { -13, -19, -9.82, 13, 11.49, -9.71, 3.36, 10, 14.52, 16, 13.66, 0.48, 4.13, -0.11, 19, -17.36, 11, 11.28, -12, -12.35 };
            CollectionAssert.AreEqual(waitArray, resArray);

        }
    }
}