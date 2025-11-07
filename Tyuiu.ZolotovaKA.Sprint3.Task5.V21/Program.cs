using Tyuiu.ZolotovaKA.Sprint3.Task5.V21.Lib;
class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнила: Золотова К. А. | ИCПб-24-1 ";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла while                                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #21                                                             *");
        Console.WriteLine("* Выполнила: Золотова К. А. | ИCПб-24-1                                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 2;
        int startValue1 = 1;
        int startValue2 = 1;
        int stopValue1 = 3;
        int stopValue2 = 10;


        Console.WriteLine("Переменная Х: " + x);
        Console.WriteLine("Старт шага первой суммы ряда: " + startValue1);
        Console.WriteLine("Конец шага первой суммы ряда: " + stopValue1);
        Console.WriteLine("Старт шага второй суммы ряда: " + startValue2);
        Console.WriteLine("Конец шага второй суммы ряда: " + stopValue2);



        Console.WriteLine("************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
        Console.WriteLine("************************************************************************");

        Console.WriteLine("Сумма ряда = " + ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));

        Console.ReadKey();
    }
}
}