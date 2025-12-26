using Tyuiu.RadkoVO.Sprint5.Task3.V7.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task3.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение f(x) = 1.6 * x³ - 2.1 * x² + 7 * x                       *");
            Console.WriteLine("* вычислить его значение при x = 2, результат сохранить                   *");
            Console.WriteLine("* в бинарный файл OutPutFileTask3.bin и вывести на консоль.               *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            Console.WriteLine($"x = {x}");

            Console.WriteLine($"Функция: f(x) = 1.6 * x³ - 2.1 * x² + 7 * x");

            DataService ds = new DataService();

            string filePath = ds.SaveToFileTextData(x);

            double y;
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                y = reader.ReadDouble();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл сохранен по пути: {filePath}");
            Console.WriteLine($"Размер файла: {new FileInfo(filePath).Length} байт");

            Console.WriteLine($"\nВычисление:");
            Console.WriteLine($"f({x}) = 1.6 * {x}³ - 2.1 * {x}² + 7 * {x}");
            Console.WriteLine($"f({x}) = 1.6 * {Math.Pow(x, 3)} - 2.1 * {Math.Pow(x, 2)} + {7 * x}");
            Console.WriteLine($"f({x}) = {1.6 * Math.Pow(x, 3)} - {2.1 * Math.Pow(x, 2)} + {7 * x}");
            Console.WriteLine($"f({x}) = {1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x:F6}");
            Console.WriteLine($"f({x}) = {y} (после округления до 3 знаков)");

            Console.WriteLine($"\nПроверка содержимого бинарного файла:");
            byte[] bytes = File.ReadAllBytes(filePath);
            Console.WriteLine($"Байты в файле: {BitConverter.ToString(bytes)}");
            Console.WriteLine($"Двойная точность: {BitConverter.ToDouble(bytes, 0)}");

            Console.ReadKey();
        }
    }
}