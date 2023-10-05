// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Pls enter first number: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Pls enter second number: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write(Math.Pow(numberOne, numberTwo));


// if (number > 0)
// {
//     for (int start = 1; start <= number; start++)
//     {
//         Console.Write(Math.Pow(start, 2) + ", ");
//     }
// }
// else
// {
//     Console.WriteLine("Number is incorrect");
// }

int Promt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Nature(int numberOne, int numberTwo)
{
    int natur = 1;
    for (int i = 0; i < numberTwo; i++)
    {
       natur *= numberOne;
    }
    return natur;
}

int numberOne = Promt("Pls enter first number: ");
int numberTwo = Promt("Pls enter second number: ");

Console.WriteLine(Nature(numberOne, numberTwo));
