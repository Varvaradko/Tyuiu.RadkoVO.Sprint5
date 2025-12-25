using Tyuiu.RadkoVO.Sprint5.Task1.V14.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = sin(x)/(x+1.7) - cos(x)*4*x - 6                     *");
            Console.WriteLine("* Произвести табулирование f(x) на заданном диапазоне [-5;5] с шагом 1.   *");
            Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt                *");
            Console.WriteLine("* и вывести на консоль в таблицу.                                         *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Стартовое значение: {startValue}");
            Console.WriteLine($"Конечное значение:  {stopValue}");
            Console.WriteLine($"Шаг: 1");
            Console.WriteLine($"Функция: F(x) = sin(x)/(x+1.7) - cos(x)*4*x - 6");

            // Создаем сервис
            DataService ds = new DataService();

            // Сохраняем результаты в файл
            Console.WriteLine("\nВычисление значений...");
            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            // Читаем результаты из файла
            string[] results = File.ReadAllLines(filePath);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл сохранен по пути: {filePath}");
            Console.WriteLine($"Размер файла: {new FileInfo(filePath).Length} байт");

            // Выводим таблицу
            Console.WriteLine("\n+------------+--------------+");
            Console.WriteLine("|     x      |     f(x)     |");
            Console.WriteLine("+------------+--------------+");

            for (int i = 0; i < results.Length; i++)
            {
                int x = startValue + i;
                double y = double.Parse(results[i]);

                Console.WriteLine("|{0, 6:d}      |   {1, 8:f2}   |", x, y);
            }

            Console.WriteLine("+------------+--------------+");

            // Дополнительная информация
            Console.WriteLine("\nПроверка деления на ноль:");
            Console.WriteLine("Знаменатель: x + 1.7");
            Console.WriteLine("Деление на ноль при x = -1.7");
            Console.WriteLine("В диапазоне [-5; 5] целых чисел деления на ноль нет.");

            // Покажем содержимое файла
            Console.WriteLine("\nСодержимое файла:");
            Console.WriteLine(File.ReadAllText(filePath));

            Console.ReadKey();
        }
    }
}

