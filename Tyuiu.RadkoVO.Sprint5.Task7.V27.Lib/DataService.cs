using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RadkoVO.Sprint5.Task7.V27.Lib
{
    public class DataService : ISprint5Task7V27
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    bool previousWasSpace = false;

                    for (int i = 0; i < line.Length; i++)
                    {
                        char c = line[i];

                        if (c == ' ')
                        {
                            if (!previousWasSpace)
                            {
                                strLine += c;
                            }
                            previousWasSpace = true;
                        }
                        else
                        {
                            strLine += c;
                            previousWasSpace = false;
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }

            }

            return pathSaveFile;
        }
    }
}