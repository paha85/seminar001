﻿// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int[,] FillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MainDiagSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}
Console.WriteLine("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(row, column);
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine($"\nSum of main diagonal is {MainDiagSum(matrix)}");