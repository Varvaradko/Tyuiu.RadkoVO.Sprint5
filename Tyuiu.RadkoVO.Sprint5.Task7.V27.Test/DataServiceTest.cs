using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RadkoVO.Sprint5.Task7.V27.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\", "DataSprint5", "InPutDataFileTask7V27.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
