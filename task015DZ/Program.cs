// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("PLS enter day of the week, from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <=7 && number > 0)
{
    if (number > 5)
    {
        Console.WriteLine("Today is weekend day");
    }
    else if (number <= 5)
    {
        Console.WriteLine("Today is working day");
    }
}
else
    Console.WriteLine("PLS enter day of the week, from 1 to 7");