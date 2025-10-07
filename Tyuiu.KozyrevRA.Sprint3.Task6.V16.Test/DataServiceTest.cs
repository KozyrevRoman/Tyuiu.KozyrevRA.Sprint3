using Tyuiu.KozyrevRA.Sprint3.Task6.V16.Lib;
namespace Tyuiu.KozyrevRA.Sprint3.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int res = ds.GetSumTheDivisors(5, 16);
            int wait = 42;
            Assert.AreEqual(wait, res);
        }

    }
}
