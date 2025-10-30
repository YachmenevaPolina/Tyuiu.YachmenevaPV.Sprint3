using Tyuiu.YachmenevaPV.Sprint3.Task1.V4.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Оператор цикла while.                                             *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #4                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, используя цикл while, которая вычисляет сумму ряда  *");
    Console.WriteLine("* по формуле.                                                             *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int startValue = 1;
    int stopValue = 10;

    Console.WriteLine("Старт шага = " + startValue);
    Console.WriteLine("Конец шага = " + stopValue);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));

    Console.ReadKey();

}
