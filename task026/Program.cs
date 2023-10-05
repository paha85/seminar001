// Задача 26: Напишите программу, которая
// принимает на вход число и выдаёт количество цифр
// в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Pls enter number: ");
int input = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(input.ToString().Length);
