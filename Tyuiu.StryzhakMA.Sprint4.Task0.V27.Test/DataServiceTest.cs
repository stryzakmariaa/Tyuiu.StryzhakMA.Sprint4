using Tyuiu.StryzhakMA.Sprint4.Task0.V27.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultOddArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = {7, 4, 3, 2, 1, 5, 9, 8, 7, 4};
            int res = ds.GetMultOddArrEl(numsArray);
            int wait = 6615;

            Assert.AreEqual(wait, res);
        }
    }
}
