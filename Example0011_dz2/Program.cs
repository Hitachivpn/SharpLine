// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267432979 -> 6

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void Task10()
{
    int num = new Random().Next(100, 999);
    Console.WriteLine(num);
    Console.WriteLine((num / 10) % 10);
};
void Task13()
{
    Console.WriteLine("Введите число для поиска третьей цифры");
    int number = Convert.ToInt32(Console.ReadLine());
    string NumberText = Convert.ToString(number);
    if (NumberText.Length > 2)
    {
        Console.WriteLine("третья цифра -> " + NumberText[2]);
    }
    else
    {
        Console.WriteLine("-> третьей цифры нет");
    }
};
void Task15()
{
    Console.WriteLine("Введите число от 1 до 7 для проверки выходного дня");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 6 || number == 7) {
    Console.WriteLine(number + " -> да");
    }
    else if (number < 1 || number > 7) {
    Console.WriteLine("это вообще не день недели");
    }
    else Console.WriteLine(number + " -> нет");
    
};

Task10();
Task13();
Task15();