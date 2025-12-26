using Tyuiu.RadkoVO.Sprint5.Task2.V12.Lib;

namespace Tyuiu.RadkoVO.Sprint5.Task2.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Радько В. О. | СМАРТб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов,                    *");
            Console.WriteLine("* заполненный значениями с клавиатуры.                                    *");
            Console.WriteLine("* Заменить положительные элементы массива на 1,                           *");
            Console.WriteLine("* отрицательные на 0.                                                     *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv                          *");
            Console.WriteLine("* и вывести на консоль.                                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Введите 9 целых чисел для матрицы 3x3:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Элемент [{i},{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.Write("Ошибка! Введите целое число: ");
                    }
                }
            }

            Console.WriteLine("\nИсходная матрица:");
            PrintMatrix(matrix);

            DataService ds = new DataService();

            Console.WriteLine("\nПреобразование матрицы...");
            string filePath = ds.SaveToFileTextData(matrix);

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Файл сохранен по пути: {filePath}");
            Console.WriteLine($"Размер файла: {new FileInfo(filePath).Length} байт");

            Console.WriteLine("\nПреобразованная матрица:");

            int[,] transformedMatrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < 3; j++)
                {
                    transformedMatrix[i, j] = int.Parse(values[j]);
                }
            }

            PrintMatrix(transformedMatrix);

            Console.WriteLine("\nСодержимое CSV файла:");
            Console.WriteLine(File.ReadAllText(filePath));

            Console.WriteLine("\nПример из условия задачи:");
            Console.WriteLine("Исходная матрица:");
            Console.WriteLine("-5; -5; 9");
            Console.WriteLine("-7; 3; -4");
            Console.WriteLine("8; 7; 9");

            Console.WriteLine("\nПосле преобразования:");
            Console.WriteLine("0; 0; 1");
            Console.WriteLine("0; 1; 0");
            Console.WriteLine("1; 1; 1");

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
