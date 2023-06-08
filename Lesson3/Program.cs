

/*int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int quarterNumber = DetermineQuarterNumber(x, y);

if (quarterNumber == -1)
{
    Console.WriteLine("Одна из координат равна нулю");
    return;
}

Console.WriteLine(quarterNumber);*/




int DetermineQuarterNumber(int x, int y)
{
    if (x > 0 & y > 0)
    {
        return 1;
    }

    if (x < 0 & y > 0)
    {
        return 2;
    }

    if (x < 0 & y < 0)
    {
        return 3;
    }

    if (x > 0 & y < 0)
    {
        return 4;
    }

    return -1;
}


//Задача 18: Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).
/*int quarterNumber = int.Parse(Console.ReadLine());

string range = GetRangeByQuarterNumber(quarterNumber);
string rangeSwitch = GetRangeByQuarterNumberSwitch(quarterNumber);

Console.WriteLine(range);

Console.WriteLine(rangeSwitch);*/

string GetRangeByQuarterNumber(int quarterNumber)
{
    if (quarterNumber == 1)
    {
        return "x > 0 & y > 0";
    }

    if (quarterNumber == 2)
    {
        return "x < 0 & y > 0";
    }

    if (quarterNumber == 3)
    {
        return "x < 0 & y < 0";
    }

    if (quarterNumber == 4)
    {
        return "x > 0 & y < 0";
    }

    return "Число должно быть от 1 до 4";
}

string GetRangeByQuarterNumberSwitch(int quarterNumber)
{
    switch (quarterNumber)
    {
        case 1: return "x > 0 & y > 0";
        case 2: return "x < 0 & y > 0";
        case 3: return "x < 0 & y < 0";
        case 4: return "x > 0 & y < 0";
        default: return "Число должно быть от 1 до 4";
    }
}

//Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

/*Console.WriteLine("Введите координаты 1 точки");
Console.Write("x1 = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y1 = ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты 1 точки");
Console.Write("x2 = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y2 = ");
int y2 = int.Parse(Console.ReadLine());

double distance = DistanceBetweenTwoPoints(x1, y1, x2, y2);

Console.WriteLine("Расстояние между двумя точками равно = ");
Console.Write(Math.Round(distance, 2));*/

double DistanceBetweenTwoPoints(int x1, int y1, int x2, int y2)
{
    //√(xb - xa)2 + (yb - ya)2 
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}

//Задача 22: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
Console.Write("number = ");
int n = int.Parse(Console.ReadLine());

PrintTableOfSquares(n);

int[] result = GetTableOfSquares(n);

Console.WriteLine(result);

Console.WriteLine(string.Join(" " ,result));
Console.WriteLine();
PrintArray(result);

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

void PrintTableOfSquares(int number)
{
    for(int i = 1; i <= number; i++)
    {
        Console.Write(i * i);
        Console.Write(" ");
    }
}

int[] GetTableOfSquares(int number)
{
    // ssdf qwerwr xcvxcv ;lk;l
    // 0     1       2      3
    int[] tableOfSquares = new int[number];

    for(int i = 0; i < tableOfSquares.Length; i++)
    {
        int tmp = i + 1;
        tableOfSquares[i] = tmp * tmp;
    }

    return tableOfSquares;
}







/*int result = Calculate(1,2);
int result2 = Calculate(423,242);
Calculate();

if(result == 3)
{
    Console.WriteLine(result);
}
else{
    Console.WriteLine("нет");
}

void Calculate()
{
    return;
    Console.WriteLine("sdfsdf");
}


int Calculate(int a, int b)
{
    return a + b;
}

bool CheckEqual(int a, int b)
{
    return a == b;
}*/


