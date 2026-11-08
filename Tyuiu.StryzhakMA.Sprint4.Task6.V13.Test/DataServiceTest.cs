using Tyuiu.StryzhakMA.Sprint4.Task6.V13.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var auto = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(auto);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
