using Newtonsoft.Json.Linq;
using Tyuiu.StryzhakMA.Sprint4.Task7.V17.Lib;

namespace Tyuiu.StryzhakMA.Sprint4.Task7.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 3;
            int m = 3;

            string str = "753159864";

            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
