// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Pls enter number from 100 to 999: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100 || number > 999)
{
    Console.Write("Pls enter correct number");
}
else
{
    int digitFirst = number % 100;
    int digitSecond = digitFirst / 10;
    Console.WriteLine(digitSecond);
}