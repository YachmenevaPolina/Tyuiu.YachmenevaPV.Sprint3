﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.YachmenevaPV.Sprint3.Task7.V8.Lib
{
    public class DataService : ISprint3Task7V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int c = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (2 - x == 0)
                {
                    y = 0;
                    valueArray[c] = y;
                    c++;
                }
                else
                {
                    y = Math.Round((Math.Sin(x) + ((Math.Cos(x) + 1) / (2 - x)) + 2 * x), 2);
                    valueArray[c] = y;
                    c++;
                }
            }
            return valueArray;
        }
    }
}
