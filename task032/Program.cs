// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

//Первый вариант
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

for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
}

Console.WriteLine($"[{string.Join(", ", arr)}]");