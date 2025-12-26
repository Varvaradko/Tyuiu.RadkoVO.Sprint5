using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadkoVO.Sprint5.Task5.V11.Lib
{
    public class DataService : ISprint5Task5V11
    {
        public double LoadFromDataFile(string path)
        {
            double product = 1;
            bool foundOdd = false;

            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();
                string[] parts = text.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string p in parts)
                {
                    try
                    {
                        double value = double.Parse(p, System.Globalization.CultureInfo.InvariantCulture);
                        value = Math.Round(value, 3);

                        if (Math.Abs(value % 1) < 0.0001)
                        {
                            int n = (int)Math.Round(value);

                            if (n % 2 != 0)
                            {
                                product *= n;
                                foundOdd = true;
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
            }

            if (!foundOdd)
            {
                return 0;
            }

            return Math.Round(product, 3);
        }
    }
}
