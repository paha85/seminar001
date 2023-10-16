// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

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

Console.WriteLine("Enter position in row: ");
int xPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter position in column: ");
int yPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(xPos <= mass.GetLength(0) && yPos <= mass.GetLength(1))
{
    int number = mass[xPos-1,yPos-1];
    Console.WriteLine($"Your number is {number}, gratz!");
}
else
{
    Console.WriteLine("Sorry, no such position in matrix! GL nex time!");
}