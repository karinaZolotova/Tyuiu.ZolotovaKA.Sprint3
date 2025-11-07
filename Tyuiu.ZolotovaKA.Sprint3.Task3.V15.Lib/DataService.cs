using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.ZolotovaKA.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0, min = 100;

            foreach (char c in value)
            {
                if (c == 'm')
                    count++;
                else
                {
                    if (count > 0)
                    {
                        if (count < min)
                        {
                            min = count;
                        }
                    }
                    count = 0;
                }
                if (count > 0 && count < min)
                {
                    min = count;
                }

                if (count <= 1)
                    count = 0;

            }
            return min;
        }
    }
}