// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Pls enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"{numberA} is bigger than {numberB}");
    Console.WriteLine("Thanks!");
}
else
{
    Console.WriteLine($"{numberB} is bigger than {numberA}");
    Console.WriteLine("Thanks!");
}