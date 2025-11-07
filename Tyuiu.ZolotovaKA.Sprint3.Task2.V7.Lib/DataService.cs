using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZolotovaKA.Sprint3.Task2.V7.Lib
{
    public class DataService : ISprint3Task2V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = 1.0 / Math.Sin(k);
                sum += term * term; // или Math.Pow(term, 2)
            }

            return sum;
        }
    }
}