using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.RadkoVO.Sprint5.Task0.V6.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            if (File.Exists(expectedPath))
            {
                File.Delete(expectedPath);
            }

            string actualPath = ds.SaveToFileTextData(3);

            Assert.AreEqual(expectedPath, actualPath);

            FileInfo fileInfo = new FileInfo(actualPath);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists, $"Файл не найден по пути: {actualPath}");

            string fileContent = File.ReadAllText(actualPath);

            double expectedValue = Math.Round(3.0 / Math.Sqrt(3.0 * 3.0 + 3.0), 3);
            string expectedContent = expectedValue.ToString();

            Assert.AreEqual(expectedContent, fileContent,
                $"Содержимое файла неверное. Ожидалось: {expectedContent}, Получено: {fileContent}");

            Console.WriteLine($"Для x = 3:");
            Console.WriteLine($"Ожидаемое значение: {expectedValue}");
            Console.WriteLine($"Содержимое файла: {fileContent}");
        }
    }
}
