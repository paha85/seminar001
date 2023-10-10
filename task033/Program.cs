// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] arr) //заполнение массива
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
}

Console.WriteLine("Pls enter number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [size];

FillArray(arr);
Console.WriteLine($"[ {string.Join(", ", arr)}]");

Console.WriteLine("Pls enter number to find: ");
int number = Convert.ToInt32(Console.ReadLine());

bool FinD = false;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == number)
    {
        FinD = true;
        break;
    }
}

Console.WriteLine(FinD);