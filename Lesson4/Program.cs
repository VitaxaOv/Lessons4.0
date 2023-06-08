
//Задача 24: Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.
//7 -> 28 
//4 -> 10 
//8 -> 36

/*int a = int.Parse(Console.ReadLine());
int result = FetSumOfNumbersUpToNumber(a);

Console.WriteLine(result);

int FetSumOfNumbersUpToNumber(int number)
{
    int sum = 0;

    for (var i = 1; i <= number; i++)
    {
        sum += i;
    }

    return sum;
}*/

//Задача 26: Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе.
//456 -> 3 78 -> 2 89126 -> 5

/*int a = int.Parse(Console.ReadLine());

int count = GetCountOfDigits(a);

Console.WriteLine(count);

int GetCountOfDigits(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number/=10;
    }

    return count;
}*/

//Задача 28: Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
//4->24
// 5->120

/*int n = int.Parse(Console.ReadLine());

int result = Factorial(n);

Console.WriteLine(result);

int Factorial(int n)
{
    int result = 1;

    for (var i = 2; i <= n; i++)
    {
        result*= i;
    }

    return result;
}*/

//Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int length = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(length);

//Console.WriteLine(string.Join(",", array));
PrintArray(array);

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
}

int[] GetRandomArray(int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2);
    }

    return array;
}