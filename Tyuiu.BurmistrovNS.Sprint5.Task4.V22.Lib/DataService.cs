using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BurmistrovNS.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            str = str.Replace(".", ",");
            double z = Math.Round(Math.Pow(Convert.ToDouble(str), 3) * Math.Sin(Convert.ToDouble(str)) - 4 * Convert.ToDouble(str), 3);
            return z;
        }
    }
}