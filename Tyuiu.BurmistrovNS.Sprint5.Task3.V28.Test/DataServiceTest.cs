using Tyuiu.BurmistrovNS.Sprint5.Task3.V28.Lib;
using System.IO;

namespace Tyuiu.BurmistrovNS.Sprint5.Task3.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}