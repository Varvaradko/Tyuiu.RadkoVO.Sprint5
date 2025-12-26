using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.RadkoVO.Sprint5.Task5.V11.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task5.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(@"C:\", "DataSprint5", "InPutDataFileTask5V11.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
