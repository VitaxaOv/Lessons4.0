/*//Задача 53: 
//Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] array = GenerateRandom2DArray(-1, -234);

PrintArray(array);
Console.WriteLine();
SwapLastAndFirstRows(array);
PrintArray(array);

void SwapLastAndFirstRows(int[,] array)
{
    if(array.GetLength(0) == 0)
    {
        return;
    }

    for (var j = 0; j < array.GetLength(1); j++)
    {
        int tmp = array[0,j];
        array[0,j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tmp;
    }
}

int[,] GenerateRandom2DArray(int m, int n)
{
    if(m < 0 || n < 0)
    {
        return new int[0,0];
    }

    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/


//Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*int[,] array = GenerateRandom2DArray(3, 4);

PrintArray(array);
Console.WriteLine();

SwapRowsAndColumns(array);
PrintArray(array);

int[,] SwapRowsAndColumns(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            result[i,j] = array[j,i];
        }
    }

    return result;
}

void SwapRowsAndColumns(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(1)){
        return;
    }
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = i; j < array.GetLength(1); j++)
        {
            int tmp = array[j, i];
            array[j, i] = array[i, j];
            array[i, j] = tmp;
        }
    }
}


// 8 8 4  (0,0) (0,1) (0,2) 
// 7 1 1  (1,0) (1,1) (1,2)
// 0 7 8  (2,0) (2,1) (2,2)

// 4 1 8  
// 8 1 7
// 8 7 0



int[,] GenerateRandom2DArray(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return new int[0, 0];
    }

    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/

//Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

/*int[] array = GenerateRandomArray(10, 0, 5);

PrintArray(array);

GetCountsNumbersInArray(array);

/*void GetCountsNumbersInArray(int[] array)
{
    HashSet<int> number = new HashSet<int>();

    for (var i = 0; i < array.Length; i++)
    {
        if (!number.Contains(array[i]))
        {
            int count = GetCount(array, array[i]);

            Console.WriteLine($"{array[i]} встречается  {count} раза");

            number.Add(array[i]);
        }
    }
}*/

/*Dictionary<int, int> result = GetCountsNumbersInArray(array);

foreach (var item in result)
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раза");
}

Dictionary<int, int> GetCountsNumbersInArray(int[] array)
{
    Dictionary<int, int> numbers = new Dictionary<int, int>();

    for (var i = 0; i < array.Length; i++)
    {
        if (!numbers.TryGetValue(array[i], out var _))
        {
            int count = GetCount(array, array[i]);

            numbers.Add(array[i], count);
        }
    }

    return numbers;
}

void GetCountsNumbersInArray(int[] array)
{
    int[] numbers = new int[array.Length];

    int index = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (!Contains(numbers,array[i]))
        {
            int count = GetCount(array, array[i]);

            Console.WriteLine($"{array[i]} встречается  {count} раза");

            numbers[index] = array[i];
            index++;
        }
    }
}

bool Contains(int[] array, int number)
{
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
        }
    }

    return false;
}




int GetCount(int[] array, int number)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            count++;
        }
    }

    return count;
}





void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(",", array));
}

int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }

    return array;
}*/

/*//Задача 59: 
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.
int[,] array = GenerateRandom2DArray(4, 4);
PrintArray(array);
(int row, int column) = GetIndexesMinElement(array);

Console.WriteLine($"{row}, {column}");

int[,] result = RemoveRowAndColumnByIndexes(array, row, column);

PrintArray(result);

int[,] RemoveRowAndColumnByIndexes(int[,] array, int row, int column)
{
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0, t = 0; j < array.GetLength(1); j++)
        {
            if (i != row & j != column)
            {
                result[k, t] = array[i, j];
                t++;
            }
        }

        if (i != row)
        {
            k++;
        }
    }

    return result;
}

(int, int) GetIndexesMinElement(int[,] array)
{
    int minElement = array[0, 0];
    int minRowIndex = 0;
    int minColumnIndex = 0;

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            if (minElement > array[i, j])
            {
                minElement = array[i, j];

                minRowIndex = i;
                minColumnIndex = j;
            }
        }
    }

    return (minRowIndex, minColumnIndex);
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
    if (m < 0 || n < 0)
    {
        return new int[0, 0];
    }

    int[,] array = new int[m, n];

    Random random = new Random();
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }

    return array;
}*/

//Задача 61: Вывести первые N строк треугольника Паскаля.
// Сделать вывод в виде равнобедренного треугольника

//                1
//            1       1
//        1       2        1
//    1       3       3        1

int n = int.Parse(Console.ReadLine());

double[] array = PrintingPascalTriangle(n);

double[] PrintingPascalTriangle(int n)
{
    if (n > 1)
    {
        PrintWhiteSpaces(n);
        Console.WriteLine(1);
    }
    double[] array = new double[] { 1, 1 };

    for (var i = 3; i <= n; i++)
    {
        double[] tempArray = new double[i];

        tempArray[0] = 1;

        for (var j = 1; j < tempArray.Length; j++)
        {
            if (j != array.Length)
            {
                tempArray[j] = array[j - 1] + array[j];
            }

            if (j == tempArray.Length - 1)
            {
                tempArray[j] = 1;
            }
        }
        PrintArray(array, n);
        array = tempArray;
    }

    PrintArray(array, n);

    return array;
}

void PrintArray(double[] array, int n)
{
    PrintWhiteSpaces(n - array.Length);
    Console.WriteLine(string.Join(", ", array));
}

void PrintWhiteSpaces(int count)
{
    while (count > 0)
    {
        Console.Write(" ");
        count--;
    }
}


//трёхмерный

int[,,] array = new int[1,2,3];

for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var k = 0; k < array.GetLength(2); k++)
        {
            array[i,j,k] = 4;
        }
    }
}

int count  = 1;

for (var i = 0; i < array.GetLength(0); i++)
{
    for (var j = 0; j < array.GetLength(1); j++)
    {
        for (var k = 0; k < array.GetLength(2); k++)
        {
            count++;
            array[i,j,k] = count;
        }
    }
}