/*
Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
6, 1, -33 -> [1, 6, -33]
*/

int task25(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// int num1 = ReadInt("Введите число ");
// int num2 = ReadInt("Введите степерь");
// Console.WriteLine(task25(num1, num2));


int task27 (int number) 
{
    int counter = Convert.ToString(number).Length;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        result = result + number%10;
        number = number/10;
    }
    return result;
}

// int num3 = ReadInt("Ввдите число для суммы чисел");
// Console.WriteLine("Сумма цифр в числе: " + task27(num3));

void printArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        if (i < array.Length - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.WriteLine(" ]");
}

int[] fillArray()
{
    Random rnd = new Random();
    int[] array = new int[8];

    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(-10, 10);
    }
    return array;
}

int[] Sorter(int[] arrayIn)
{
    int len = arrayIn.Length;
    for (int i = 0; i < len; i++)
        for (int j = i; j < len; j++)
            if(Math.Abs(arrayIn[j]) < Math.Abs(arrayIn[i]))
            {
                int tmp = arrayIn[j];
                arrayIn[j] = arrayIn[i];
                arrayIn[i] = tmp;
            }
    return arrayIn;
}

int[] someArr = fillArray();
printArray(someArr);
Console.WriteLine();
printArray(Sorter(someArr));