using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;  // ДОБАВИТЬ ЭТУ СТРОЧКУ
using Tyuiu.RadkoVO.Sprint5.Task4.V1.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            // Исправить: добавить .txt в конце
            string path = Path.Combine(@"C:\", "DataSprint5", "InPutDataFileTask4V1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}


