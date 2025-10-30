using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YachmenevaPV.Sprint3.Task1.V4.Lib
{
    public class DataService : ISprint3Task1V4
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int k = 1;
            while (k <= 10)
            {
                sum = sum + Math.Pow((1 / k), 2);
                k++;
            }
            return Math.Round(sum, 3);
        }
    }
}
