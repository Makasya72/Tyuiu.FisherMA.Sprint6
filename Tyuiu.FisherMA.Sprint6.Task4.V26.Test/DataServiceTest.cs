using Tyuiu.FisherMA.Sprint6.Task4.V26.Lib;

namespace Tyuiu.FisherMA.Sprint6.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] expected =
            {
                19.81,
                16.79,
                13.87,
                10.98,
                7.94,
                3.00,
                3.23,
                -0.45,
                -3.79,
                -6.97,
                -10.00
            };

            double[] result = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(expected, result);
        }
    }
}