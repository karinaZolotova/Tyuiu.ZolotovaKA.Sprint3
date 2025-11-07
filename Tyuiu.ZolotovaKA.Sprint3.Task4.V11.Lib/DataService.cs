using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZolotovaKA.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }
                else
                {
                    res *= x / (Math.Sin(x) - x) + 2;
                }
            }
            return Math.Round(res, 3);
        }
    }
}