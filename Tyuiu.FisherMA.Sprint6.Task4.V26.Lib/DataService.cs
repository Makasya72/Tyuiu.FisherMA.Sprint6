using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FisherMA.Sprint6.Task4.V26.Lib
{
    public class DataService : ISprint6Task4V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denom = 2 * x - 0.5;

                if (denom == 0)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double y = 5 - 3 * x + (1 + Math.Sin(x)) / denom;
                    valueArray[i] = Math.Round(y, 2);
                }

                i++;
            }

            return valueArray;
        }
    }
}