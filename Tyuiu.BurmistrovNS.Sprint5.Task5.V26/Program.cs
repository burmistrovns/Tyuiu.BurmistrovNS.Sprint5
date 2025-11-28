using Tyuiu.BurmistrovNS.Sprint5.Task5.V26.Lib;
namespace Tyuiu.BurmistrovNS.Sprint5.Task5.V26
{
    class Programm
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V26.txt";
            Console.WriteLine($"* Файл сохранен: {path}                                                  *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"* Результат: {ds.LoadFromDataFile(path)}                                 *");


            Console.ReadKey();


        }



    }




}