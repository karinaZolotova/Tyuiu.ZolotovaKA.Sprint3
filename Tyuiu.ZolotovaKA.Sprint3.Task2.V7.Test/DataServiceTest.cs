using Tyuiu.ZolotovaKA.Sprint3.Task2.V7.Lib;
namespace Tyuiu.ZolotovaKA.Sprint3.Task2.V7.Test
{


    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;
            double value = ds.GetSumSeries(startValue, stopValue);

            // Ожидаемое значение (можно рассчитать заранее или проверить корректность вычислений)
            double wait = 0;
            for (int k = startValue; k <= stopValue; k++)
            {
                wait += Math.Pow(1.0 / Math.Sin(k), 2);
            }

            Assert.AreEqual(wait, value, 0.0001, "Сумма ряда вычислена неверно");
        }

        [TestMethod]
        public void GetSumSeriesSingleElement()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;
            double value = ds.GetSumSeries(startValue, stopValue);

            double expected = Math.Pow(1.0 / Math.Sin(1), 2);

            Assert.AreEqual(expected, value, 0.0001, "Сумма для одного элемента вычислена неверно");
        }

        [TestMethod]
        public void GetSumSeriesTwoElements()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 2;
            double value = ds.GetSumSeries(startValue, stopValue);

            double expected = Math.Pow(1.0 / Math.Sin(1), 2) + Math.Pow(1.0 / Math.Sin(2), 2);

            Assert.AreEqual(expected, value, 0.0001, "Сумма для двух элементов вычислена неверно");
        }

        [TestMethod]
        public void GetSumSeriesSameStartStop()
        {
            DataService ds = new DataService();

            int startValue = 5;
            int stopValue = 5;
            double value = ds.GetSumSeries(startValue, stopValue);

            double expected = Math.Pow(1.0 / Math.Sin(5), 2);

            Assert.AreEqual(expected, value, 0.0001, "Сумма при одинаковых start и stop вычислена неверно");
        }

        [TestMethod]
        public void GetSumSeriesReverseRange()
        {
            DataService ds = new DataService();

            int startValue = 3;
            int stopValue = 1;
            double value = ds.GetSumSeries(startValue, stopValue);

            // Ожидаем 0, так как startValue > stopValue
            double expected = 0;

            Assert.AreEqual(expected, value, 0.0001, "Сумма для обратного диапазона должна быть 0");
        }
    }
}