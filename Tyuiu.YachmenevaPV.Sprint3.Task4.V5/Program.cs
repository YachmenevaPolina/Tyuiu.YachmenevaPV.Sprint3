using Tyuiu.YachmenevaPV.Sprint3.Task4.V5.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Использование операторов continue и break.                        *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #5                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* На отрезке от -5 до 5, вычислить значение функции y = (cos(x)-sin(x))/x.*");
    Console.WriteLine("* При х = 0 прервать цикл.                                                *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    int startValue = -5;
    int stopValue = 5;

    Console.WriteLine("Начало шага = " + startValue);
    Console.WriteLine("Конец шага = " + stopValue);


    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Сумма значение = " + ds.Calculate(startValue, stopValue));

    Console.ReadKey();
}