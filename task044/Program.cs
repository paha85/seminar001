﻿// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Pls enter the number of Fib: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] number = new int[size];
if(size < 2){
    Console.Write("Too less Fibs");
}
else{
    number[0] = 0;
    number[1] = 1;
    for (int i = 2; i < size; i++)
    {
        number[i] = number[i - 1] + number[i - 2];
    }
    Console.WriteLine(string.Join(", ", number));
}