// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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
        mass[i, j] = rnd.Next(0, 10);
    }
}

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(mass[i, j] + ", ");
    }
    Console.WriteLine();
}

for (int i = 0; i < mass.GetLength(1); i++)
{
    int temp = mass[mass.GetLength(0) - 1, i];
    mass[mass.GetLength(0) - 1, i] = mass[0, i];
    mass[0, i] = temp;    
}

Console.WriteLine();

for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(mass[i, j] + ", ");
    }
    Console.WriteLine();
}
