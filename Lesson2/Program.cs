//9. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.
//78 -> 8 
//12-> 2
// 85 -> 8

/*Random random = new Random();
int randomNumber = random.Next(10, 100);

int lastDigit = randomNumber % 10;
int first = randomNumber / 10;

Console.WriteLine(randomNumber);

if (first > lastDigit)
{
    Console.WriteLine(first);
}
else
{
    Console.WriteLine(lastDigit);
}*/


//11. Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
//456 -> 46 
//782 -> 72
// 918 -> 98

/*Random random = new Random();

int randomNumber = random.Next(100,1000);

int lastDigit = randomNumber % 10;

int first = randomNumber / 100;

Console.WriteLine(randomNumber);

Console.WriteLine(first * 10 + lastDigit);*/

//12. Напишите программу, которая будет принимать 
//на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

/*int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
int remainder = firstNumber % secondNumber;

if (remainder == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine($"не кратно - oстаток {remainder}");
}*/

//14. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//14 -> нет 46 -> нет 161 -> да

//int number = int.Parse(Console.ReadLine());

/*if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}*/

/*if (number % 7 == 0)
{
    if (number % 23 == 0)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("нет");
}*/

//16. Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> да 
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());

int powFirstNumber = firstNumber * firstNumber;
int powSecondNumber = secondNumber * secondNumber;

// | - или (одно из условий должно быть true)
// & - и (оба условия должны быть true)

if (powFirstNumber == secondNumber | powSecondNumber == firstNumber)
{
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}