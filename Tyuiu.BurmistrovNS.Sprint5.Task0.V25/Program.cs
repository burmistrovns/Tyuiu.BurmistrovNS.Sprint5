using Tyuiu.BurmistrovNS.Sprint5.Task0.V25.Lib;
namespace Tyuiu.BurmistrovNS.Sprint5.Task0.V25
{
    class Programm
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат сохранен в файл: {path}");
            Console.WriteLine("***************************************************************************");

            
            string result = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();



        }



    }




}