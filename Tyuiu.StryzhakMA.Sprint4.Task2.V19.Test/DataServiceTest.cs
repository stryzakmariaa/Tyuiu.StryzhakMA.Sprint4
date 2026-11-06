using Tyuiu.StryzhakMA.Sprint4.Task2.V19.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 5, 4, 6, 7, 8, 9, 4, 4, 4, 8, 8, 8, 6, 8 };
            int res = ds.Calculate(numsArray);
            int wait = 21;

            Assert.AreEqual(wait, res);
        }
    }
}
