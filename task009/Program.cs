// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Random number: {number}");
int digitFirst = number /1 0;
int digitSecond = number % 10;

if (digitFirst > digitSecond)
{
    System.Console.WriteLine(digitFirst);
}
else
{
    System.Console.WriteLine(digitSecond);
}