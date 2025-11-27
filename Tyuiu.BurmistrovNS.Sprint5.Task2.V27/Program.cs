using Tyuiu.BurmistrovNS.Sprint5.Task2.V27.Lib;
namespace Tyuiu.BurmistrovNS.Sprint5.Task2.V27
{
    class Programm
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Результирующий массив:");
            Console.WriteLine("***************************************************************************");

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Файл с результатами: " + path);
            Console.ReadKey();

        }



    }




}