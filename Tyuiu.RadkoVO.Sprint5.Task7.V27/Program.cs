using Tyuiu.RadkoVO.Sprint5.Task7.V27.Lib;


DataService ds = new DataService();

Console.Title = "Спринт #5 | Выполнила: Радько Варвара Олеговна | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #27                                                             *");
Console.WriteLine("* Выполнила: Радько Варвара Олеговна | СМАРТб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл в котором есть набор символьных данных.                        *");
Console.WriteLine("* Удалить все пробелы, идущие подряд больше одного.                       *");
Console.WriteLine("* Полученный результат сохранить в файл.                                  *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V27.txt");
string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V27.txt");

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Находится в файле: ");
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine(pathSaveFile);
Console.ReadKey();