// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.


//Первый вариант
// void FillArray(int[] arr) //заполнение массива
// {
//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(-9, 10);
//     }
// }

// Console.WriteLine("Pls enter number of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int [size];
// int positive = 0;
// int negative = 0;

// FillArray(arr);

// Console.WriteLine(string.Join(", ", arr));

// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] > 0)
//     {
//         positive += arr[i];
//     }
//     else
//     {
//         negative += arr[i];
//     }
// }

// Console.WriteLine($"Sum of Positives is {positive}. Sum of Negative is {negative}");

//Второй вариант

void FillArray(int[] arr) //заполнение массива
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
}

void SumPositiveAndNegative(int[] arr, out int positive, out int negative)
{
    positive = 0;
    negative = 0;
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            positive += arr[i];
        }
        else
        {
            negative += arr[i];
        }
    }
}

Console.WriteLine("Pls enter number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [size];

FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
SumPositiveAndNegative(arr, out int pos, out int neg);


Console.WriteLine($"Sum of Positives is {pos}. Sum of Negative is {neg}");