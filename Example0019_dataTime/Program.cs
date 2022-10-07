
String[,] s0 ={
{"0000"},
{"0  0"},
{"0  0"},
{"0  0"},
{"0000"},};
String[,] s1 ={
{"   0"},
{"  00"},
{" 0 0"},
{"   0"},
{"   0"},};
String[,] s2 ={
{"0000"},
{"   0"},
{"0000"},
{"0   "},
{"0000"},
};
String[,] s3 ={
{"0000"},
{"   0"},
{"0000"},
{"   0"},
{"0000"},
};
String[,] s4 ={
{"0  0"},
{"0  0"},
{"0000"},
{"   0"},
{"   0"},
};
String[,] s5 ={
{"0000"},
{"0   "},
{"0000"},
{"   0"},
{"0000"},
};
String[,] s6 ={
{"0000"},
{"0   "},
{"0000"},
{"0  0"},
{"0000"},
};
String[,] s7 ={
{"0000"},
{"   0"},
{"  0 "},
{" 0  "},
{"0   "},
};
String[,] s8 ={
{"0000"},
{"0  0"},
{"0000"},
{"0  0"},
{"0000"},
};
String[,] s9 ={
{"0000"},
{"0  0"},
{"0000"},
{"   0"},
{"0000"},
};

DateTime dateTime = new DateTime();
dateTime = DateTime.Now;
int h1 = 0;
int h2 = 0;
int min1 = 1;
int min2 = 2;
String[,] mas1 = s0;
String[,] mas2 = s0;
String[,] mas3 = s0;
String[,] mas4 = s0;
while (true)
{
    //Console.Clear();
    // dateTime = DateTime.Now;
    // Console.Write($"{dateTime.Hour}:{dateTime.Minute}:{dateTime.Second} ");

    dateTime = DateTime.Now;
    h1 = dateTime.Hour / 10;
    h2 = dateTime.Hour % 10;
    min1 = dateTime.Minute / 10;
    min2 = dateTime.Minute % 10;
    for (int i = 0; i < 5; i++)
    {
        switch (h1)
        {
            case 0:
                mas1 = s0;
                break;
            case 1:
                mas1 = s1;
                break;
            case 2:
                mas1 = s2;
                break;
            case 3:
                mas1 = s3;
                break;
            case 4:
                mas1 = s4;
                break;
            case 5:
                mas1 = s5;
                break;
            case 6:
                mas1 = s6;
                break;
            case 7:
                mas1 = s7;
                break;
            case 8:
                mas1 = s8;
                break;
            case 9:
                mas1 = s9;
                break;
        }
        switch (h2)
        {
            case 0:
                mas2 = s0;
                break;
            case 1:
                mas2 = s1;
                break;
            case 2:
                mas2 = s2;
                break;
            case 3:
                mas2 = s3;
                break;
            case 4:
                mas2 = s4;
                break;
            case 5:
                mas2 = s5;
                break;
            case 6:
                mas2 = s6;
                break;
            case 7:
                mas2 = s7;
                break;
            case 8:
                mas2 = s8;
                break;
            case 9:
                mas2 = s9;
                break;
        }
        switch (min1)
        {
            case 0:
                mas3 = s0;
                break;
            case 1:
                mas3 = s1;
                break;
            case 2:
                mas3 = s2;
                break;
            case 3:
                mas3 = s3;
                break;
            case 4:
                mas3 = s4;
                break;
            case 5:
                mas3 = s5;
                break;
            case 6:
                mas3 = s6;
                break;
            case 7:
                mas3 = s7;
                break;
            case 8:
                mas3 = s8;
                break;
            case 9:
                mas3 = s9;
                break;
        }
        switch (min2)
        {
            case 0:
                mas4 = s0;
                break;
            case 1:
                mas4 = s1;
                break;
            case 2:
                mas4 = s2;
                break;
            case 3:
                mas4 = s3;
                break;
            case 4:
                mas4 = s4;
                break;
            case 5:
                mas4 = s5;
                break;
            case 6:
                mas4 = s6;
                break;
            case 7:
                mas4 = s7;
                break;
            case 8:
                mas4 = s8;
                break;
            case 9:
                mas4 = s9;
                break;
        }
        Console.Write(mas1[i, 0]);
        Console.Write("  ");
        Console.Write(mas2[i, 0]);
        Console.Write("  ");
        Console.Write("|");
        Console.Write("  ");
        Console.Write(mas3[i, 0]);
        Console.Write("  ");
        Console.Write(mas4[i, 0]);
        Console.WriteLine();
    }
    Thread.Sleep(3000);
    Console.Clear();




}
void printBoard(string[,] num)
{
    foreach (String s1 in num)
    {
        Console.WriteLine(s1);
    }
}




