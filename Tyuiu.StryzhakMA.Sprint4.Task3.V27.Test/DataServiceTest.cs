using Tyuiu.StryzhakMA.Sprint4.Task3.V27.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task3.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { 4, 3, 5, 5, 3 },
                { 6, 7, 4, 4, 3 },
                { 3, 3, 7, 3, 6 },
                { 3, 4, 3, 7, 7 },
                { 3, 5, 6, 3, 6 }
            };
            int wait = 8;
            int res = ds.Calculate(mas2);

            Assert.AreEqual(wait, res);
        }
    }
}
