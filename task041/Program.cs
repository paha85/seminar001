﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}

int[] InputArray(int length){
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Pls enter {i + 1} element: ");
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0){
            count++;
        }
    }
    return count;
}

int length = Promt("Pls enter number of elements: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Number of positive elements - {CountPositiveNumbers(array)}");