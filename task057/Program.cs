// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
    Console.WriteLine();
}

int[] CountMatrix(int[,] matrix)
{
    int[] counter = new int[10];
    for (int k = 0; k < 10; k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if(matrix[i, j] == k)
                {
                    counter[k]++;
                }
            }
        }
    }
    return counter;
}

Console.WriteLine("Enter number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(row, column);
PrintMatrix(matrix);
int[] counter = CountMatrix(matrix);

Console.WriteLine("\nVar.1");
for (int k = 0; k < 10; k++)
{
    if(counter[k] != 0)
    {
        Console.WriteLine($"number {k} in matrix {counter[k]}");
    }
}

Console.WriteLine("\nVar.2");
int count = 0;
for (int k = 0; k < 10; k++)
{
    count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] == k)
            {
                count++;
            }
        }
    }
    if(counter[k] != 0)
        Console.WriteLine($"number {k} in matrix {counter[k]}");
}