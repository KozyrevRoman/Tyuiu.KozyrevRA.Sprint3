using Tyuiu.KozyrevRA.Sprint3.Task5.V28.Lib;
namespace Tyuiu.KozyrevRA.Sprint3.Task5.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            double res = ds.GetSumSumSeries(2, 1, 1, 12, 3); 
            double wait = 832.355;
            Assert.AreEqual(wait, res);
        }
    }
}
