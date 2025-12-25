using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadkoVO.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            double y;
            string strY;

            for (int x = startValue; x <= stopValue; x++)
            {

                double denominator = x + 1.7;

                if (Math.Abs(denominator) < 0.0001) 
                {
                    y = 0; 
                }
                else
                {
                 
                    double part1 = Math.Sin(x) / denominator;

                    double part2 = Math.Cos(x) * 4 * x;

                    y = part1 - part2 - 6;
                }

                y = Math.Round(y, 2);
                strY = y.ToString();

                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }

            return path;
        }
    }
}
