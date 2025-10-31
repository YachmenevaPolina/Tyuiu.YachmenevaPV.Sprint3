using Tyuiu.YachmenevaPV.Sprint3.Task7.V8.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Добавление к решению итоговых проектов.                           *");
    Console.WriteLine("* Задание #7                                                              *");
    Console.WriteLine("* Вариант #8                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая выводит таблицу значений функции.           *");
    Console.WriteLine("*                                                                         *");
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

    Console.WriteLine("+----------+----------+");
    Console.WriteLine("|     X    |   f(x)   |");
    Console.WriteLine("+----------+----------+");
    for (int i = 0; i <= len - 1; i++)
    {
        Console.WriteLine("|{0,5:d}     |  {1, 5:f2}   |", startValue, valueArray[i]);
        startValue++;
    }
    Console.WriteLine("+----------+----------+");
    Console.ReadKey();
}