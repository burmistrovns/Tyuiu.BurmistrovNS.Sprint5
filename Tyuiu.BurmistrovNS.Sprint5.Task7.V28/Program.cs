using Tyuiu.BurmistrovNS.Sprint5.Task7.V28.Lib;
namespace Tyuiu.BurmistrovNS.Sprint5.Task7.V28
{
    class Programm
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V28.txt" });
            string pathSaveFile = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V28.txt" });

            Console.WriteLine("Данные находтся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pathSaveFile = ds.LoadDataAndSave(pathSaveFile);
            Console.WriteLine(pathSaveFile);




            Console.ReadKey();



        }



    }




}