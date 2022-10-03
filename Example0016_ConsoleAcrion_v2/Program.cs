
class position
{
    int x = 1;
    int y = 1;
}
class Program
{
    static void Main()
    {
        // Отрисовка поля 
        void map(string[,] mass)
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(mass[i][j]);
                }
                Console.WriteLine();
            }
        }
        // W A S D 

        string[,] numbers =
        {
        { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
        { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" },
        };

        //map(numbers);

        // for (int d = 0; d < 10; d++)
        // {
        //     var move = Console.ReadKey();
        //     // if (move = "w") position.y++;
        //     // if (move = "s") position.y--;
        //     // if (move = "a") position.x--;
        //     // if (move = "d") position.x++;
        //     map();
        


        // }
    }
}
