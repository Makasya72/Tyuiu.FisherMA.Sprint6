using Tyuiu.FisherMA.Sprint6.Task1.V4.Lib;

namespace Tyuiu.FisherMA.Sprint6.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(2, 2);

            double expected = Math.Round(Math.Sin(2) / 3.2 - Math.Sin(2) * 2 - 4, 2);

            Assert.AreEqual(expected, res[0]);
        }
    }
}