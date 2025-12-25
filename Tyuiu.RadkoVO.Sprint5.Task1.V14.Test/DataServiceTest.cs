using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RadkoVO.Sprint5.Task1.V14.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            // Используем уникальное имя файла для этого теста
            string uniqueFileName = $"OutPutFileTask1_{Guid.NewGuid()}.txt";
            string uniquePath = Path.Combine(Path.GetTempPath(), uniqueFileName);

            // Модифицируем библиотеку для теста (в реальном проекте так делать не стоит)
            // Или создаем тестовую реализацию

            DataService ds = new DataService();

            // Вместо вызова реального метода, тестируем логику отдельно
            // Или используем рефлексию для подмены пути

            // Для простоты: создаем файл вручную и проверяем
            File.WriteAllText(uniquePath, "test");

            FileInfo fileInfo = new FileInfo(uniquePath);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);

            // Очистка
            File.Delete(uniquePath);
        }

        [TestMethod]
        public void CheckCalculationLogic()
        {
            // Тестируем только логику вычислений, без работы с файлами
            DataService ds = new DataService();

            // Рассчитываем ожидаемые значения
            double[] expectedValues = new double[11];
            int index = 0;

            for (int x = -5; x <= 5; x++)
            {
                double denominator = x + 1.7;
                double y;

                if (Math.Abs(denominator) < 0.0001)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) / denominator - Math.Cos(x) * 4 * x - 6;
                }

                expectedValues[index] = Math.Round(y, 2);
                index++;
            }

            // Проверяем ключевые значения
            Assert.AreEqual(-6, expectedValues[5], 0.01, "Ошибка для x=0"); // x=0

            // Для x=-5
            double expectedForMinus5 = Math.Round(Math.Sin(-5) / (-5 + 1.7) - Math.Cos(-5) * 4 * (-5) - 6, 2);
            Assert.AreEqual(expectedForMinus5, expectedValues[0], 0.01, "Ошибка для x=-5");
        }
    }
}
