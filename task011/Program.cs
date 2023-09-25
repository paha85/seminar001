// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number: {number}");

int digitFirst = number / 100;
int digitSecond = number % 10;
int digitThird = digitFirst * 10 + digitSecond;
Console.WriteLine(digitThird);