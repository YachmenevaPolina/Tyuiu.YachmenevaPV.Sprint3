﻿using Tyuiu.YachmenevaPV.Sprint3.Task2.V26.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Оператор цикла do-while.                                          *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #26                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, используя цикл do- while, которая вычисляет         *");
    Console.WriteLine("* произведение ряда по формуле, при х = 0,25.                             *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    double value = 0.25;
    int startValue = 1;
    int stopValue = 17;

    Console.WriteLine("Переменная Х = " + value);
    Console.WriteLine("Старт шага = " + startValue);
    Console.WriteLine("Конец шага = " + stopValue);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value, startValue, stopValue));

    Console.ReadKey();
}
