using Tyuiu.YachmenevaPV.Sprint3.Task0.V25.Lib;
{
    DataService ds = new DataService();

    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Оператор цикла for.                                               *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #25                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
    Console.WriteLine("* по формуле, при X=5.                                                    *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int value = 5;
    int startValue = 1;
    int stopValue = 14;

    Console.WriteLine("Переменная Х = " + value);
    Console.WriteLine("Старт шага = " + startValue);
    Console.WriteLine("Конец шага = " + stopValue);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));

    Console.ReadKey();
}
