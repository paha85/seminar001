// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы.


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

void PrintMatrix(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] TranspMatrix(int[,] mass)
{
    int[,] newMass = new int[mass.GetLength(1), mass.GetLength(0)];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            newMass[j, i] = mass[i, j];
        }
    }
    return newMass;
}

PrintMatrix(mass);
PrintMatrix(TranspMatrix(mass));