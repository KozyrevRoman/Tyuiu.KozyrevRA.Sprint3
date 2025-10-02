using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KozyrevRA.Sprint3.Task2.V15.Lib
{
    public class DataService : ISprint3Task2V15
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double a = value;
            double s = 0.0;
            int k = startValue;
            do
            {
                s += (Math.Pow(a, k) + 0.5) * Math.Cos(k); 
                k++;
            } while (k <= stopValue);
            return Math.Round(s,3);
        }
    }
}
