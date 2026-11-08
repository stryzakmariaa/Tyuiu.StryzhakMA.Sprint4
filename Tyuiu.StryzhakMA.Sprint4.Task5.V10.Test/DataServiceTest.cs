using Tyuiu.StryzhakMA.Sprint4.Task5.V10.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds  = new DataService();
            int[,] mtrx = new int[5, 5]
            {
                { 1,  2, -3,  4, -1 },
                { 0,  5,  6, -2,  7 },
                {-4, -1,  2,  3,  0 },
                { 1, -2, -3,  4,  5 },
                { 2,  0,  1, -1,  3 },
            };
            int wait = 46;
            int res = ds.Calculate(mtrx);
            Assert.AreEqual(wait, res);
        }
    }
}
