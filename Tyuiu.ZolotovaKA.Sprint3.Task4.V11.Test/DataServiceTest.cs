using Tyuiu.ZolotovaKA.Sprint3.Task4.V11.Lib;
namespace Tyuiu.ZolotovaKA.Sprint3.Task4.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            var res = ds.Calculate(startValue, stopValue);
            double wait = 0.84;
            Assert.AreEqual(wait, res);
        }
    }
}