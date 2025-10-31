﻿using Tyuiu.YachmenevaPV.Sprint3.Task6.V5.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Обработка целочисленной информации.                               *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #5                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих       *");
    Console.WriteLine("* отрезку [15,22], сумму всех делителей.                                  *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int startValue = 15;
    int stopValue = 22;

    Console.WriteLine("Начало отрезка = " + startValue);
    Console.WriteLine("Конец отрезка = " + stopValue);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

    Console.ReadKey();
}