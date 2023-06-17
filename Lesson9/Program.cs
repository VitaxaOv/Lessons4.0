//Задача 63: 
// Задайте значение N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"


//int n = int.Parse(Console.ReadLine());

/*PrintNumbers(n);

void PrintNumbers(int n)
{
    int number = n - 1;
    if (n < 1)
    {
        return;
    }

    PrintNumbers(number);
    Console.Write($"{n} ");
}*/

/*//Задача 65: Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

PrintNumbersInRange(m, n);

void PrintNumbersInRange(int m, int n)
{
    if (m > n)
    {
        return;
    }

    Console.Write($"{m} ");
    PrintNumbersInRange(++m, n);
}*/

/*//Задача 67: Напишите программу, которая будет принимать на вход число 
//и возвращать сумму его цифр.
//453 -> 12
// 45 -> 9

int number = 15;//int.Parse(Console.ReadLine());

int sum = GetSumOfDigitsInNumber(number);

Console.WriteLine($"Сумма цифр в числе равна - {sum}");

int GetSumOfDigitsInNumber(int number)
{
    if(number == 0)
    {
        return 0;
    }

    return GetSumOfDigitsInNumber(number / 10) + number % 10;
}*/


//Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243
//A = 2; B = 3 -> 8

int a = 3;//int.Parse(Console.ReadLine());

int b = 5;//int.Parse(Console.ReadLine());

int result = Pow(a,b);
Console.WriteLine(result);

int Pow(int a, int b)
{
    if(b == 0)
    {
        return 1;
    }

    return Pow(a,--b) * a;
}
//   243 
//1) 71 * 3  // b = 5
//2) 27 * 3  // b = 4
//3) 9 * 3 // b = 3
//4) 3 * 3 // b = 2
//5) 1 * 3 // b = 1
//5) 1 // b = 1


