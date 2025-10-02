using Tyuiu.KozyrevRA.Sprint3.Task3V26.Lib;
namespace Tyuiu.KozyrevRA.Sprint3.Task3V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            int res = ds.GetCharCount("have a nice time", 'e'); 
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
