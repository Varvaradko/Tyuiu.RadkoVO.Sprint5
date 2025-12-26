using System.IO;
using Tyuiu.RadkoVO.Sprint5.Task3.V7.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAll()
        {
            DataService ds = new DataService();

            string filePath = Path.Combine(Path.GetTempPath(), $"OutPutFileTask3_{Guid.NewGuid()}.bin");

            double y = 1.6 * Math.Pow(2, 3) - 2.1 * Math.Pow(2, 2) + 7 * 2;
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(y);
            }

            Assert.IsTrue(File.Exists(filePath));

            FileInfo fileInfo = new FileInfo(filePath);
            Assert.AreEqual(8, fileInfo.Length);

            double valueFromFile;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                valueFromFile = reader.ReadDouble();
            }

            Assert.AreEqual(18.4, valueFromFile, 0.001);

            File.Delete(filePath);
        }
    }
}
