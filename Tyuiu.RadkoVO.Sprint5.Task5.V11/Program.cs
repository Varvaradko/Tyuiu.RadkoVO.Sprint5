using Tyuiu.RadkoVO.Sprint5.Task5.V11.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V21.txt                     *");
            Console.WriteLine("* в котором есть набор значений.                                          *");
            Console.WriteLine("* Найти произведение всех нечетных целых чисел в файле.                   *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V11.txt";
            Console.WriteLine($"Файл: {path}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            try
            {
                DataService ds = new DataService();

                string fileContent = File.ReadAllText(path);
                Console.WriteLine($"Содержимое файла: {fileContent}");
                Console.WriteLine();

                double result = ds.LoadFromDataFile(path);

                Console.WriteLine("Анализ данных:");
                string[] numbers = fileContent.Split(new char[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                int product = 1;
                bool firstOdd = true;

                foreach (string numStr in numbers)
                {
                    if (double.TryParse(numStr, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        value = Math.Round(value, 3);

                        if (Math.Abs(value % 1) < 0.0001)
                        {
                            int n = (int)Math.Round(value);

                            if (n % 2 != 0)
                            {
                                Console.WriteLine($"  {n} - нечетное целое число");
                                if (firstOdd)
                                {
                                    product = n;
                                    firstOdd = false;
                                }
                                else
                                {
                                    product *= n;
                                }
                            }
                            else
                            {
                                Console.WriteLine($"  {n} - четное целое число (пропускаем)");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"  {value} - вещественное число (пропускаем)");
                        }
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"Произведение всех нечетных целых чисел: {result}");

                if (result == 0)
                {
                    Console.WriteLine("В файле не найдено нечетных целых чисел.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ОШИБКА: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}
