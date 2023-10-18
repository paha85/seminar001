
Console.Clear();
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Pow(int firstNumber, int secondNumber)
{
    if (secondNumber == 0) return 1;
    return firstNumber * Pow(firstNumber, secondNumber - 1);
}
Console.WriteLine();
int firstNumber = InputNumbers("Pls enter FIRST number: ");
int secondNumber = InputNumbers("Pls enter SECOND number: ");
Console.Write($"{Pow(firstNumber, secondNumber)}");