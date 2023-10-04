// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Pls enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int start = 1; start <= number; start++)
    {
        Console.Write(Math.Pow(start, 3) + ", ");
    }
}
else
{
    Console.WriteLine("Number is incorrect");
}