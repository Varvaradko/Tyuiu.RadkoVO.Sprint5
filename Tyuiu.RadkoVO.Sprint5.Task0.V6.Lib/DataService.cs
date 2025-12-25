using System;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadkoVO.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string fileName = "OutPutFileTask0.txt";
            string path = Path.Combine(Path.GetTempPath(), fileName);

            double numerator = x; 
            double denominator = Math.Sqrt(x * x + x); 

            if (Math.Abs(denominator) < 0.0001)
            {
                throw new DivideByZeroException("Знаменатель близок к нулю");
            }

            double y = numerator / denominator;
            y = Math.Round(y, 3); 

            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}

