//Задача 39: 
//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
PrintArray(array);
Reverse(array);
PrintArray(array);

void Reverse(int[] array)
{
    for (var i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[^(i + 1)];
        array[^(i + 1)] = array[i];
        array[i] = tmp;
        // array[^(i+1)] == array[array.Length - 1 - i]
    }
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}
*/

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать
//треугольник с сторонами такой длины.

/*int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

Console.WriteLine(CheckSum(a, b, c));

bool CheckSum(int a, int b, int c)
{
    return a < b + c & b < a + c & c < b + a;
}*/

//Задача 42: Напишите программу, 
//которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

/*int number = int.Parse(Console.ReadLine());
string result = ToBinary(number);
Console.WriteLine(result);

string ToBinary(int number)
{
    string result = string.Empty;
    while(number != 0)
    {
        result = number % 2 + result;
        number = number / 2;
    }

    return result;
}*/

//Задача 44: Не используя рекурсию, выведите первые
//N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

/*int n = int.Parse(Console.ReadLine());
PrintFibonacciNumbers(n);

void PrintFibonacciNumbers(int n)
{
    int firstNumber = 0;
    int secondNumber = 1;

    if (n == 1)
    {
        Console.Write("0 ");
        return;
    }
    if (n > 1)
    {
        Console.Write("0 1 ");
    }

    int sum = 0;
    for (var i = 2; i < n; i++)
    {
        sum = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = sum;
        Console.Write(sum);
        Console.Write(" ");
    }
}*/

//Задача 45:
// Напишите программу, которая будет создавать 
//копию заданного массива с помощью
//поэлементного копирования.

//  1) Значимые типы данных  
//  2) Ссылочные типы данных

int a = 5;

int b = a;

b++;

//Console.WriteLine(a);
//Console.WriteLine(b);

int[] array = new int[] { 1, 2, 3, 4, 5, 6 };
int[] array2 = Copy(array);

array2[1] = 123;

PrintArray(array);
PrintArray(array2);

int[] Copy(int[] array)
{
    int[] result = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }

    return result;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}




