using System;
using System.IO;
using Tyuiu.RadkoVO.Sprint5.Task6.V11.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Найти количество слов длиной шесть символов в заданной строке.          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:\", "DataSprint5", "InPutDataFileTask6V11.txt");

            Console.WriteLine("Данные находятся в файле: " + path);

            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден! Создайте файл по указанному пути.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();
                int res = ds.LoadFromDataFile(path);

                Console.WriteLine("Количество слов длиной 6 символа: " + res);

                Console.WriteLine("\nСодержимое файла:");
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
