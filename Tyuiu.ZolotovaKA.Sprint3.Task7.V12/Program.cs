using Tyuiu.ZolotovaKA.Sprint3.Task7.V12.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнила: Хубулова В. И. | АСОИУб-23-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Хубулова Валерия Игоревна | АСОИУб-23-2                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая выводит таблицу значений функции (произвести*");
        Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5;5] с шагом 1. Произвести  *");
        Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.       *");
        Console.WriteLine("* Значения занести в массив. Значения округлить до 2 знаков после запятой *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray;
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("+--------+-----------+");
        Console.WriteLine("|   X    +   f(x)    |");
        Console.WriteLine("+--------+-----------+");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0,5:d}   |   {1, 6:f2}  |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+--------+-----------+");

        Console.ReadKey();
    }
}
