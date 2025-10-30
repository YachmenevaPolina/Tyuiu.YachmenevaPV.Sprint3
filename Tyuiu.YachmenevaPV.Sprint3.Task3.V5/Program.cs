using Tyuiu.YachmenevaPV.Sprint3.Task3.V5.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #3 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #3                                                               *");
    Console.WriteLine("* Тема: Оператор foreach.                                                 *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #5                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Используя цикл foreach заменить а на * в строке.                        *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string value = "fifa al fall";
    char replaceable = 'a';
    char replacement = '*';

    Console.WriteLine("Исходная строка = " + value);
    Console.WriteLine("Искомый символ = " + replaceable);
    Console.WriteLine("Заменимый символ = " + replacement);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Итоговая строка = " + ds.ReplaceCharInString(value, replaceable, replacement));

    Console.ReadKey();
}