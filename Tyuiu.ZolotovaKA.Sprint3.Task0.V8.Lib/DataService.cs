using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZolotovaKA.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double res = 1;
            for (int i = startValue; i <= stopValue; i++)
            {
                res *= ((Math.Pow(value, i) + 1) * Math.Cos(4));
            }
            return Math.Round(res, 3);
        }
    }
}