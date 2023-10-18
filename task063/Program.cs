
Console.Clear();
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void WayToNumber(int number)
{
    if(number == 0)
    {
        return;
    }
    WayToNumber(number - 1);
    Console.Write($"{number} ");
}
Console.WriteLine();
int number = InputNumbers("Pls enter THE number: ");
WayToNumber(number);