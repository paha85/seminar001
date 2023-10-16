// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

// public static class RandomExtensions
// {
//     public static double NextDouble(
//         this Random random,
//         double minValue,
//         double maxValue)
//     {
//         return random.NextDouble() * (maxValue - minValue) + minValue;
//     }
// }

Console.WriteLine("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] mass = new double[row, column];
Random rnd = new Random();
Console.WriteLine();

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        mass[i, j] = rnd.NextDouble() * (10 -(-10)) + (-10);
    }
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write($"{mass[i, j]:F2}, ");
    }
    Console.WriteLine();
}