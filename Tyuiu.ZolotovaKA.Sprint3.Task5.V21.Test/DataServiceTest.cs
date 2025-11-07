using Tyuiu.ZolotovaKA.Sprint3.Task5.V21.Lib;
namespace Tyuiu.ZolotovaKA.Sprint3.Task5.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataService ds = new DataService();
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;
            int x = 2;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 25.981;

            Assert.AreEqual(wait, res);
        }
    }

}