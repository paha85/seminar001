// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] mass = new int [8];
// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = new Random().Next(0,2);
// }

// for (int i = 0; i < mass.Length; i++)
// {
//     Console.Write($"{mass[i]}");
// }


int[] mass = new int [8];
Random rnd = new Random();
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = rnd.Next(0,10);
}

Console.Write("[" + string.Join(", ", mass) + "]");

// for (int i = 0; i < mass.Length; i++)
// {
//     Console.Write($"{mass[i]} ");
// }