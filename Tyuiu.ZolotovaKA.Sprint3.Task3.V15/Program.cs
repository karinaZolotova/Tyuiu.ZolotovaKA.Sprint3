using Tyuiu.ZolotovaKA.Sprint3.Task3.V15.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Золотова К.А. | ИСПб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Оператор цикла for                                                      *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Золотова К.А. | ИСПб-24-1                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв m,        *");
        Console.WriteLine("* находящихся на соседних позициях в строке: lrmmse mg sermmmrt           *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string s = "lrmmse mg sermmmrt";
        char c = 'm';
        Console.WriteLine("Исходная строка = " + s);
        Console.WriteLine("Искомый символ = " + c);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество символов = " + ds.GetMinCharCount(s, c));
        Console.ReadKey();
    }
}
}