using System;
using System.IO;
using Tyuiu.RadkoVO.Sprint5.Task2.V12.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAllFunctionality()
        {
            DataService ds = new DataService();

            int[,] matrix = new int[3, 3]
            {
                { -5, -5, 9 },
                { -7, 3, -4 },
                { 8, 7, 9 }
            };

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.IsTrue(fileExists);
            Assert.AreEqual("OutPutFileTask2.csv", fileInfo.Name);

            string content = File.ReadAllText(path);
            string[] lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(3, lines.Length);

            Assert.AreEqual("0;0;1", lines[0]);
            Assert.AreEqual("0;1;0", lines[1]);
            Assert.AreEqual("1;1;1", lines[2]);
        }
    }
}
