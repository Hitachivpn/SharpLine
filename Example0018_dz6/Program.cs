// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


void task41()
{
    Console.Write("Введите числа через запятую: ");
    int[] numbers = StringToNum(Console.ReadLine());
    PrintArray(numbers);
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            sum++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"значений больше 0 = {sum}");


    int[] StringToNum(string input)
    {
        int count = 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == ',')
            {
                count++;
            }
        }

        int[] numbers = new int[count];
        int index = 0;

        for (int i = 0; i < input.Length; i++)
        {
            string temp = "";

            while (input[i] != ',')
            {
                if (i != input.Length - 1)
                {
                    temp += input[i].ToString();
                    i++;
                }
                else
                {
                    temp += input[i].ToString();
                    break;
                }
            }
            numbers[index] = Convert.ToInt32(temp);
            index++;
        }
        return numbers;
    }

    void PrintArray(int[] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write("]");
    }
}

void task43()
{
    Console.WriteLine("введите b1");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите k1");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите b2");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите k2");
    double k2 = Convert.ToInt32(Console.ReadLine());

    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;

    Console.WriteLine($"прямые пересекутся в точке x: {x}, y: {y}");
}


Console.WriteLine("Введите номер задачи 1 или 2");
int Num = int.Parse(Console.ReadLine() ?? "0"); //int.Parse тот же Convert.ToInt32, только вроде бы работает быстрее
if (Num == 1) task41();
if (Num == 2) task43();
if (Num != 1 && Num != 2) Console.WriteLine("Неверное значение. Введите только цифру 1, 2.");