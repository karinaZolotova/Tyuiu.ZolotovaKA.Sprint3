using Tyuiu.ZolotovaKA.Sprint3.Task6.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил Золотова К.А. | ИСПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание №6                                                              *");
        Console.WriteLine("* Вариант №3                                                              *");
        Console.WriteLine("* Выполнил Золотова К.А. | ИСПб-24-1                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*Написать программу, которая вычислит cумму делителей, больше 8           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* [13,19], d>8                                                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        int res = ds.GetSumTheDivisors(13, 19);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}
