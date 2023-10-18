//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30
 
Console.Clear();
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SumFromMToN(int n, int m)
{
  if (n == m) return n;
  else return SumFromMToN(n + 1, m) + n;
}

Console.WriteLine();
int firstNumber = InputNumbers("Pls enter FIRST number: ");
int secondNumber = InputNumbers("Pls enter SECOND number: ");
Console.WriteLine($"Sum of numbers from {firstNumber} to {secondNumber} is {SumFromMToN(firstNumber, secondNumber)}");