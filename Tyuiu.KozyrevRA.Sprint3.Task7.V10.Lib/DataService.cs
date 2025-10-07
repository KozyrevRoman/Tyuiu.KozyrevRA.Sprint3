using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KozyrevRA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Sin(x) + 3 == 0)
                    valueArray[count] = 0.00;
                else
                    valueArray[count] = Math.Round(((5.0 * x + 2.5) / (Math.Sin(x) + 3.0)) + 2.0 * x + Math.Cos(x), 2);
                count++;
            }

            return valueArray;
        }
    }
}
