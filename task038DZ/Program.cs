//  Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
        
    }
}

Console.Write("Pls enter number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];

FillArray(arr);
Console.WriteLine($"Массив:\n{string.Join("\t", arr)}");

int max = arr[0];
int min = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    else if (arr[i] < min)
    {
        min = arr[i];
    }
}

Console.WriteLine($"max number in aray: {max}");
Console.WriteLine($"min number in aray: {min}");
Console.WriteLine($"diff between max and min: {max}-{min}={max-min}");
