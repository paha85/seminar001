//  Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  N = 5. -> "5, 4, 3, 2, 1"
//  N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"
 
Console.Clear();
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WayToNumber(int number, int start)
{
    if(start > number)
    {
        return;
    }
    WayToNumber(number, start +1);
    Console.Write($"{start} ");
}
Console.WriteLine();
int number = InputNumbers("Pls enter THE number: ");
int start = 1;
WayToNumber(number, start);