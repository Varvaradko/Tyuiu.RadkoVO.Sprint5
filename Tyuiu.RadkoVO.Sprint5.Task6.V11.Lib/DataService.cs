using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadkoVO.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace(",", " ").Replace(".", " ");

                    string[] parts = line.Split(' ');

                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (parts[i].Length == 6)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
