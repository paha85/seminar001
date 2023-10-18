
Console.Clear();
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WayToNumber(int firstNumber, int secondNumber)
{
    if (firstNumber - 1 == secondNumber) return;
    WayToNumber(firstNumber, secondNumber - 1);
    Console.Write($"{secondNumber} ");
}
Console.WriteLine();
int firstNumber = InputNumbers("Pls enter FIRST number: ");
int secondNumber = InputNumbers("Pls enter SECOND number: ");
WayToNumber(firstNumber, secondNumber);