using Tyuiu.BurmistrovNS.Sprint5.Task6.V3.Lib;
using System.IO;


namespace Tyuiu.BurmistrovNS.Sprint5.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(res, 21);
        }
    }
}