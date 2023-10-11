﻿// Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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
Console.WriteLine($"Массив:\n[{string.Join(" ", arr)}]");

void ReverseArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
ReverseArray(arr);
Console.WriteLine($"Массив:\n[{string.Join(" ", arr)}]");