using Tyuiu.ZolotovaKA.Sprint3.Task3.V15.Lib;
namespace Tyuiu.ZolotovaKA.Sprint3.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "lrmmse mg sermmmrt";
            int wait = 1;
            var res = ds.GetMinCharCount(str, 'm');
            Assert.AreEqual(wait, res);
        }
    }
}