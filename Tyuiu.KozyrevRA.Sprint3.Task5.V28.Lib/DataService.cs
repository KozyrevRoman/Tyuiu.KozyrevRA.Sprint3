using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KozyrevRA.Sprint3.Task5.V28.Lib
{                                                                           
    public class DataService : ISprint3Task5V28
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0.0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++) 
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    res += (Math.Pow(k, x) / Math.Sin(k));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
