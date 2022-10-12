void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void task54()
{
    Console.WriteLine("введите количество строк");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите количество столбцов");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine();
    Console.WriteLine("Массив до изменения");
    PrintArray(numbers);
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями");
    PrintArray(numbers);
}
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void task56()
{
    Console.WriteLine("введите размер квадратного массива");
    int massVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[massVol, massVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    int minsum = Int32.MaxValue;
    int indexLine = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
}
// Задача 58: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void task58()
{
    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[,] nums = new int[size, size];
    int num = 1;
    int i = 0;
    int j = 0;
    while (num <= size * size)
    {
        nums[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }
    PrintArray(nums);
}
Console.WriteLine("Введите номер задачи 1 2 или 3");
int Num = int.Parse(Console.ReadLine() ?? "0"); //int.Parse тот же Convert.ToInt32, только вроде бы работает быстрее
if (Num == 1) task54();
if (Num == 2) task56();
if (Num == 3) task58();
if (Num != 1 && Num != 2 && Num != 3) Console.WriteLine("Неверное значение. Введите только цифру 1, 2.");