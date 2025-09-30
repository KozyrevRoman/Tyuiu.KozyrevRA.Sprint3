using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KozyrevRA.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultSeries = 1.0;
            int i;
            for(i = startValue; i <= stopValue; i++)
            {
                MultSeries *= (Math.Pow(value, i) + (1.0 / (1.0 + i))); 
            }

            return Math.Round(MultSeries, 3);
        }
    }
}
