// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Pls enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    for (int start = 1; start <= number; start++)
    {
        Console.Write(Math.Pow(start, 2) + ", ");
    }
}
else
{
    Console.WriteLine("Number is incorrect");
}