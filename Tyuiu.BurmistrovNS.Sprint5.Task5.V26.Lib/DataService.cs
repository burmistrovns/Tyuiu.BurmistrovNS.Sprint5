using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.BurmistrovNS.Sprint5.Task5.V26.Lib
{
    public class DataService : ISprint5Task5V26
    {
        public double LoadFromDataFile(string path)
        {
            double resp = 0;
            double reso = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ');

                    foreach (string numStr in numbers)
                    {
                        double x = double.Parse(numStr, CultureInfo.InvariantCulture);
                        if (x % 1 != 0)
                        {
                            if (x >= 0)
                            {
                                resp += x;
                            }
                            else
                            {
                                reso += x;
                            }
                        }
                    }
                }
            }
            return Math.Round((resp - reso), 3);
        }
    }
}