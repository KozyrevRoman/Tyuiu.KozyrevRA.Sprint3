using Tyuiu.KozyrevRA.Sprint3.Task4.V7.Lib;
namespace Tyuiu.KozyrevRA.Sprint3.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(-5, 5);
            double wait = 1231.499;
            Assert.AreEqual(wait, res);
        }
    }
}
