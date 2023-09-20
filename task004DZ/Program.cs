// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Pls enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"{numberA} is bigger than {numberB} and {numberC}");
    Console.WriteLine("Thanks!");
}
else if (numberB > numberC && numberB > numberA)
{
    Console.WriteLine($"{numberB} is bigger than {numberA} and {numberC}");
    Console.WriteLine("Thanks!");
}
else
{
    Console.WriteLine($"{numberC} is bigger than {numberA} and {numberB}");
    Console.WriteLine("Thanks!");
}