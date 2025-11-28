using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BurmistrovNS.Sprint5.Task3.V28.Lib
{
    public class DataService : ISprint5Task3V28
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            double y = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}