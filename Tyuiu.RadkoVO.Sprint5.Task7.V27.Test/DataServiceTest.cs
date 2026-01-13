using System.IO;
using Tyuiu.RadkoVO.Sprint5.Task7.V27.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string inputPath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V27.txt");
            File.WriteAllText(inputPath, "Тестовые     данные");

            // 2. Запускаем обработку
            DataService ds = new DataService();
            ds.LoadDataAndSave(inputPath);

            // 3. Теперь проверяем существование выходного файла
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");
            FileInfo fileInfo = new FileInfo(outputPath);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists,
                $"Файл {outputPath} не был создан. Проверьте работу метода LoadDataAndSave.");
        }
    }
}