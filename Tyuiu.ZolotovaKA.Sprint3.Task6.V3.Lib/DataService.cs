using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZolotovaKA.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sumd = 0;
            for (int x = startValue; x <= stopValue; x++)
                for (int d = 1; d <= x; d++)
                    if (x % d == 0)
                        if (d > 8)
                            sumd = sumd + d;
            return sumd;

        }
    }