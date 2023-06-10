/*
//Задача 46: 
//Задайте двумерный массив размером m×n, 
//заполненный случайными целыми числами.

Console.Write("Введите количество строк - ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов - ");
int n = int.Parse(Console.ReadLine());

int[,] array = GenerateRandom2DArray(m,n);

PrintArray(array);

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandom2DArray(int m, int n)
{
    int[,] array = new int[m,n]; 

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(0,10);
            Console.Write($"({i},{j})");
        }

        Console.WriteLine();
    }

    return array;
}


// 1 2 3  (0,0) (0,1) (0,2)
// 2 3 4  (1,0) (1,1) (1,2)
// 3 3 4  (2,0) (2,1) (2,2)
// 4 4 4  (3,0) (3,1) (3,2)
*/


/*//Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Ai,j = i+j. 
//Выведите полученный массив на экран.

int[,] array = GenerateArrayUsingFormula(3,4);
PrintArray(array);

int[,] GenerateArrayUsingFormula(int m, int n)
{
    int[,] array = new int[m, n];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i+j;
        }
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"({i},{j}) ");
        }
        Console.WriteLine();
    }
}*/

/*//Задача 49: Задайте двумерный массив. Найдите элементы, у
//которых оба индекса чётные, и замените эти элементы на их
//квадраты.

int[,] array = GenerateRandom2DArray(3, 4);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SquareElementsWithBothIndexesEven(array);
PrintArray(array);
void SquareElementsWithBothIndexesEven(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = (int)Math.Pow(array[i, j], 2);
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 & j % 2 == 0)
            {
                array[i, j] = (int)Math.Pow(array[i, j], 2);
            }
        }
    }
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GenerateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write($"({i},{j})");
        }

        Console.WriteLine();
    }

    return array;
}*/

//Задача 51: Задайте двумерный массив. Найдите сумму
//элементов, находящихся на главной диагонали (с индексами
//(0,0); (1;1) и т.д.

int[,] array = GenerateRandom2DArray(10, 2);
PrintArray(array);
int sum = GetSumOfElementsOnDiagonal(array);
Console.WriteLine();
Console.WriteLine(sum);

/*int GetSumOfElementsOnDiagonal(int[,] array)
{
    int sum = 0;
    for (var i = 0; i < Math.Min(array.GetLength(0), array.GetLength(1)); i++)
    {
        sum += array[i,i];
    }

    return sum;
}*/

int GetSumOfElementsOnDiagonal(int[,] array)
{
    int sum = 0;
    for (var i = 0; i < Math.Min(array.GetLength(0), array.GetLength(1)); i++)
    {
        sum += array[i,i];
    }

    return sum;
}

int Min(int value1, int value2){
    if(value1 > value2){
        return value2;
    }

    return value1;
}



int[,] GenerateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
            Console.Write($"({i},{j})");
        }

        Console.WriteLine();
    }

    return array;
}

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}