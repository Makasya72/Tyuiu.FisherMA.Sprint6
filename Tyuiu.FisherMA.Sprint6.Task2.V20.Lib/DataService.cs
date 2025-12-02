


using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FisherMA.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] vArray;
            int len = (stopValue - startValue) + 1;
            vArray = new double[len];

            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 1.2 == 0)
                {
                    vArray[count] = 0;
                    count++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) / (x + 1.2)) - (Math.Sin(x) * 2) - (2 * x), 2);
                    vArray[count] = y;
                    count++;
                }
            }
            return vArray;
        }
    }
}