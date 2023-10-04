// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

// void CheckQuatr (int x)
// {    
//     if (x == 1)
//     {
//         Console.WriteLine("x > 0 and y > 0");
//     }

//     else if (x == 2)
//     {
//         Console.WriteLine("x < 0 and y > 0");
//     }

//     else if (x == 3)
//     {
//         Console.WriteLine("x < 0 and y < 0");
//     }

//     else if (x == 4)
//     {
//         Console.WriteLine("x > 0 and y < 0");
//     }

//     else
//     {
//         Console.WriteLine("only numbers from 1 to 4");
//     }
// }
// Console.Write("Pls enter quater number: ");
// int a = Convert.ToInt32(Console.ReadLine());

// CheckQuatr(a);

string[] quaters = {"x > 0, y > 0",
                    "x < 0, y > 0",
                    "x < 0, y < 0",
                    "x > 0, y < 0"};

Console.Write("Pls enter quater number: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a >= 1 && a <= 4)
{
    Console.WriteLine(quaters[a-1]);
}
else
{
    Console.WriteLine("no such quater");
}