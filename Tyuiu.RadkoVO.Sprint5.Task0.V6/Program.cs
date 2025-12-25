using Tyuiu.RadkoVO.Sprint5.Task0.V6.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("* Формула: y = x / √(x² + x)                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 3;
            Console.WriteLine($"x = {x}");

            // Создаем сервис
            DataService ds = new DataService();

            // Сохраняем результат в файл
            string filePath = ds.SaveToFileTextData(x);

            // Читаем результат из файла
            string result = File.ReadAllText(filePath);
            double y = double.Parse(result);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл сохранен по пути: {filePath}");
            Console.WriteLine($"Результат вычисления: y = {y}");


            Console.ReadKey();
        }
    }
}