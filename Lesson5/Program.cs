//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
//из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.

/*int[] array = GenerateRandomArray(4, -9, 10);

Console.WriteLine(string.Join(", ", array));
// string.Join(разделитель, массив) -> строку элементов разделенные - ", "

int sumPositiveNumbers = GetSumPositiveNumbers(array);
Console.Write("Sum positive numbers = ");
Console.WriteLine(sumPositiveNumbers);
int sumNegativeNumbers = GetSumNegativeNumbers(array);
Console.Write("Sum negative numbers = ");
Console.WriteLine(sumNegativeNumbers);*/

/*int GetSumPositiveNumbers(int[] array)
{
    int sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }

    return sum;
}

int GetSumNegativeNumbers(int[] array)
{
    int sum = 0;

    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }

    return sum;
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

//Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/*int[] randomArray = GenerateRandomArray(5, -9, 10);

Console.WriteLine("Initial array - ");
PrintArray(randomArray);
ChangeSignOfNumbers(randomArray);
Console.WriteLine("Result array - ");
PrintArray(randomArray);*/

/*void ChangeSignOfNumbers(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        //array[i] = array[i] * (-1);
        array[i] = -array[i];
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}*/

//Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.

/*int[] array = GenerateRandomArray(10, -9, 10);
PrintArray(array);

Console.Write("Введите число - ");
int number = int.Parse(Console.ReadLine());

bool result = Contains(number, array);
Console.WriteLine(result);

bool Contains(int number, int[] array)
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

Console.WriteLine(array.Contains(number));*/

/*Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].*/

/*int[] array = GenerateRandomArray(10, 10, 200);

PrintArray(array);

int count = CountElementsInRange(array, 10, 99);

Console.WriteLine(count);*/

/*int CountElementsInRange(int[] array, int startOfRange, int endOfRange)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i] >= startOfRange & array[i] <= endOfRange)
        {
            count++;
        }
    }

    return count;
}*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

int[] array = GenerateRandomArray(6, 0, 10);
PrintArray(array);


int[] result = MultiplyPairsInArray(array);
PrintArray(result);

int[] MultiplyPairsInArray(int[] array)
{
    int[] result = new int[array.Length / 2 + array.Length % 2];
    for (var i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[(array.Length) / 2];
    }

    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
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
}



/*void MultiplyPairsInArray(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        Console.Write(array[i] * array[array.Length - 1 - i]);
        Console.Write(" ");
    }

    if (array.Length % 2 != 0)
    {
        Console.Write(array[(array.Length) / 2]);
    }
}*/