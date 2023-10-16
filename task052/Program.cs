// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

Console.WriteLine("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[row, column];
Random rnd = new Random();
Console.WriteLine();

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        mass[i, j] = rnd.Next(0, 100);
    }
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write($"{mass[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int j = 0; j < mass.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        avarage = (avarage + mass[i, j]);
    }
    avarage = avarage / row;
    Console.WriteLine($"{avarage:F2};");
}