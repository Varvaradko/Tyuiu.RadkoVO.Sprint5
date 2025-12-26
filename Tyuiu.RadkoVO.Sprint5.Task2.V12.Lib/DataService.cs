using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadkoVO.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V14
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            int rows = matrix.GetLength(0);  
            int columns = matrix.GetLength(1); 

            int[,] transformedMatrix = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (transformedMatrix[i, j] > 0)
                    {
                        transformedMatrix[i, j] = 1;
                    }
                    else if (transformedMatrix[i, j] < 0)
                    {
                        transformedMatrix[i, j] = 0;
                    }
  
                }
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string str = "";
                    for (int j = 0; j < columns; j++)
                    {
                        str += transformedMatrix[i, j];

                        if (j != columns - 1)
                        {
                            str += ";";
                        }
                    }

                    writer.Write(str);

                    if (i != rows - 1)
                    {
                        writer.Write(Environment.NewLine);
                    }
                }
            }

            return path;
        }
    }
}
