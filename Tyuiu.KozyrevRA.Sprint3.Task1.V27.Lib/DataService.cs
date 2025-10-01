using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KozyrevRA.Sprint3.Task1.V27.Lib
{
    public class DataService : ISprint3Task1V27
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MultSeries = 1.0;    
            while (startValue<=stopValue) 
            {
                MultSeries *= Math.Pow((1.0 / (Math.Pow(value, startValue))),3);
                startValue++;
            }

            return Math.Round(MultSeries, 3);
        }
    }
}
