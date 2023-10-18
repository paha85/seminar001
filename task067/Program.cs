
Console.Clear();
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int SumDigital(int firstNumber)
{
    if (firstNumber == 0) return 0;
    return (firstNumber % 10) + SumDigital(firstNumber / 10);
}
Console.WriteLine();
int firstNumber = InputNumbers("Pls enter THE number: ");

Console.WriteLine(SumDigital(firstNumber));