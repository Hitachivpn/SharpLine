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
    for (int i = 0; i < NumberText.Length; i++)
    {
        Console.WriteLine(NumberText[i]);
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

//Task10();
Task13();
//Task15();

void task_23()
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Число\tКвадрат");
    for (int i = 1; i <= number; i++)
    {
        Console.WriteLine("{0}\t{1}\t", i, Math.Pow(i,3));
    }

}
task_23();


void task_21(){
Console.WriteLine("Введите координаты точки А: ");
Console.WriteLine("X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int by = Convert.ToInt32(Console.ReadLine());

int k = bx - ax;
int m = by - ay;

double length = Math.Sqrt(k * k + m * m);
length = Math.Round(length, 2);
Console.WriteLine($"Длинна {length}");
}
task_21();

void Zadacha19()
{
    Console.WriteLine("Введите координату х первой точки");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y первой точки");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату х второй точки");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y второй точки");
    int y2 = Convert.ToInt32(Console.ReadLine());
    double R = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    Console.WriteLine("Расстояние между точками ="  + R);
}
Zadacha19();
