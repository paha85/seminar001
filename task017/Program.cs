// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

void CheckQuatr (int x, int y)
{    
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1st quater");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4th quater");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3rd quater");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("2rd quater");
    }
    else
    {
        Console.WriteLine("no zeros pls");
    }
}
Console.Write("Pls enter X number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter Y number: ");
int b = Convert.ToInt32(Console.ReadLine());

CheckQuatr(a, b);
// if (x > 0 && y > 0)
// {
//     Console.WriteLine("1st quater");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("4th quater");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("3rd quater");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("2rd quater");
// }
// else
// {
//     Console.WriteLine("no zeros pls");
// }