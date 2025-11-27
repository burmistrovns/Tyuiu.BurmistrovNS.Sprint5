using Tyuiu.BurmistrovNS.Sprint5.Task0.V25.Lib;
using System.IO;

namespace Tyuiu.BurmistrovNS.Sprint5.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);

            
            Assert.AreEqual("9,037", result);
        }
    }
}