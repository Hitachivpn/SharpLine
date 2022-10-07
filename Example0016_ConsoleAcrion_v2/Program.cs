
// class position
// {
//     int x = 1;
//     int y = 1;
// }
// class Program
// {
//     static void Main()
//     {
//         // Отрисовка поля 
//         void map(string[,] mass)
//         {
//             for (int i = 0; i < 12; i++)
//             {
//                 for (int j = 0; j < 12; j++)
//                 {
//                     Console.Write(mass[i][j]);
//                 }
//                 Console.WriteLine();
//             }
//         }
//         // W A S D 

//         string[,] numbers =
// //         {
//         { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "X" },
//         { "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X", "X" },
//         };

//         //map(numbers);

//         // for (int d = 0; d < 10; d++)
//         // {
//         //     var move = Console.ReadKey();
//         //     // if (move = "w") position.y++;
//         //     // if (move = "s") position.y--;
//         //     // if (move = "a") position.x--;
//         //     // if (move = "d") position.x++;
//         //     map();



//         // }
//     }
// }


Console.Clear();
int x;
int y;

void printSimbol(int posX, int posY)
{
    Console.SetCursorPosition(posX, posY);
    Console.Write("@");
}
void moveSimbol()
{
    int DownArrow = 0;
    int RigthArrow = 0;
    while (true)
    {
        ConsoleKeyInfo cki;
        // Console.TreatControlCAsInput = true;
        cki = Console.ReadKey();
        //Console.WriteLine(cki.Key.ToString());
        if (cki.Key == ConsoleKey.Escape)   break;
        if (cki.Key == ConsoleKey.RightArrow && RigthArrow < 50)
        {
            Console.Clear();
            printBoard();
            RigthArrow++;
            printSimbol(RigthArrow, DownArrow);
        }
        if (cki.Key == ConsoleKey.DownArrow && DownArrow < 6)
        {

            Console.Clear();
            printBoard();
            DownArrow++;
            printSimbol(RigthArrow, DownArrow);
        }
        if (cki.Key == ConsoleKey.LeftArrow && RigthArrow > 0)
        {
            Console.Clear();
            printBoard();
            RigthArrow--;
            printSimbol(RigthArrow, DownArrow);
        }
        if (cki.Key == ConsoleKey.UpArrow && DownArrow > 0)
        {
            Console.Clear();
            printBoard();
            DownArrow--;
            printSimbol(RigthArrow, DownArrow);
        }
    }
}


void printBoard()
{
    String[,] s ={
                // {".................................................."},
                // {".................................................."},
                // {".................................................."},
                // {".................................................."},
                // {".................................................."},
                // {".................................................."},
                // {".................................................."},
                
                {"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"},
                {"X................................................X"},
                {"X................................................X"},
                {"X................................................X"},
                {"X................................................X"},
                {"X................................................X"},
                {"X................................................X"},
                {"XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"},
                };

    foreach (String s1 in s)
    {
        Console.WriteLine(s1);
    }
}
moveSimbol();

