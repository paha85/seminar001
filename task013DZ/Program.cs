// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Pls enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("There must be at least 3 digits in number");
    return;
}
else
    while (number > 999)
    {
        number /= 10;
    }
    Console.WriteLine(number % 10);