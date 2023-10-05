// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int SumNumbers (int num)
{
    int sum = 1;
    for (int i = 1; i <= num ; i++)
    {
        sum = sum * i;
    }
    return sum;
}

Console.WriteLine("Pls enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(number);
Console.WriteLine($" result is {result}");