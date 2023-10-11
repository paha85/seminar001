// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] arr){
    int[] arrCopy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    return arrCopy;
}

int[] arrCopy = CopyArray(arr);

Console.WriteLine($"Массив Копия:\n[{string.Join(" ", arrCopy)}]");