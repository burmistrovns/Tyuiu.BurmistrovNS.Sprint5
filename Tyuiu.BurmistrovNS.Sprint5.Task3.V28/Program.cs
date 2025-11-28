using Tyuiu.BurmistrovNS.Sprint5.Task3.V28.Lib;
namespace Tyuiu.BurmistrovNS.Sprint5.Task3.V28  
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
            Console.WriteLine("x = " + x);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double y = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);
            y = Math.Round(y, 3);

            Console.WriteLine("y = " + y);

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            
            Console.ReadKey();



        }



    }




}