using Tyuiu.RadkoVO.Sprint5.Task4.V1.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task4.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt                       *");
            Console.WriteLine("* в котором есть вещественное значение.                                   *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле.            *");
            Console.WriteLine("* Вычислить значение по формуле y = 1 / (cos(x) + x) - 4.12 * x           *");
            Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой)            *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V1.txt";
            Console.WriteLine($"Файл: {path}");

            // Проверяем существование файла
            if (!File.Exists(path))
            {
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ВНИМАНИЕ: Файл не найден!                                              *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Для работы программы необходимо:                                       *");
                Console.WriteLine("* 1. Создать папку: C:\\DataSprint5\\                                    *");
                Console.WriteLine("* 2. Создать файл: InPutDataFileTask4V0.txt                              *");
                Console.WriteLine("* 3. Записать в файл вещественное число (например: 2.5)                  *");
                Console.WriteLine("***************************************************************************");
                Console.ReadKey();
                return;
            }

            // Читаем значение из файла
            string fileContent = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {fileContent}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                // Создаем объект DataService и вычисляем результат
                DataService ds = new DataService();
                double result = ds.LoadFromDataFile(path);

                Console.WriteLine($"Результат вычисления: y = {result}");

                // Дополнительно показываем вычисления
                double x = double.Parse(fileContent, System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine("\nПодробное вычисление:");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"cos(x) = {Math.Cos(x):F6}");
                Console.WriteLine($"cos(x) + x = {Math.Cos(x) + x:F6}");
                Console.WriteLine($"1 / (cos(x) + x) = {1 / (Math.Cos(x) + x):F6}");
                Console.WriteLine($"4.12 * x = {4.12 * x:F6}");
                Console.WriteLine($"y = 1 / (cos(x) + x) - 4.12 * x = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("ОШИБКА: Файл должен содержать вещественное число!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ОШИБКА: Деление на ноль! (cos(x) + x = 0)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}