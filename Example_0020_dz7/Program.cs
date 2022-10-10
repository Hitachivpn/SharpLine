// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void task47()
{
    Console.WriteLine("введите число строк");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите число столбцов");
    int colum = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[line, colum];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);

    void FillArrayRandomNumbers(double[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(random.Next(-100, 100) + random.NextDouble());
            }
        }
    }

    void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17->такого числа в массиве нет
void task50()
{
    Console.WriteLine("введите номер строки");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите номер столбца");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[10, 10];
    FillArrayRandomNumbers(numbers);

    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
    }
    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-100, 100);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void task52()
{
    Console.WriteLine("введите количество строк");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[n, m];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine();
    PrintArray(numbers);
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            avarage = (avarage + numbers[i, j]);
        }
        avarage = avarage / n;
        Console.Write(avarage + "; " + "\t");
    }


    void FillArrayRandomNumbers(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(0, 100);
            }
        }
    }

    void PrintArray(int[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}

Console.WriteLine("Введите номер задачи 1 2 или 3");
int Num = int.Parse(Console.ReadLine() ?? "0"); //int.Parse тот же Convert.ToInt32, только вроде бы работает быстрее
if (Num == 1) task47();
if (Num == 2) task50();
if (Num == 3) task52();
if (Num != 1 && Num != 2 && Num != 3) Console.WriteLine("Неверное значение. Введите только цифру 1, 2.");