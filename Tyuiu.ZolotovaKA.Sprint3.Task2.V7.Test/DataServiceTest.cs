using Tyuiu.ZolotovaKA.Sprint3.Task2.V7.Lib;
namespace Tyuiu.ZolotovaKA.Sprint3.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "gft hggt ntg";
            char replaceable = 'g';
            char replacement = '4';
            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);
            string wait = "4ft h44t nt4";
            Assert.AreEqual(res, wait);
        }
    }
}