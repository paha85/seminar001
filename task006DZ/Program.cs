// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Pls enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
// int numberB =  Convert.ToInt32(numberA % 2);
if (numberA % 2 == 0) //if (numberB == 0)
{
    Console.WriteLine($"{numberA} is even");
    Console.WriteLine("Thanks!");
}
else
{
    Console.WriteLine($"{numberA} is odd");
    Console.WriteLine("Thanks!");
}