// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int sumOfNumbers = 0;
for (int i = 1; i < arr.Length; i+=2)
{
    sumOfNumbers += arr[i];    
}

Console.WriteLine($"Сумма элементов нечетных индексов: {sumOfNumbers}");