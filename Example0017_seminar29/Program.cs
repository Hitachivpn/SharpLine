Console.WriteLine("Hello, World!");
//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

void Zadacha2()
{
    int size = 6;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[] numbers)
{
    Random random = new Random();
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(-9, 10);
    }
}

void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i]*-1 + " ");
        
    }
}

Zadacha2();
