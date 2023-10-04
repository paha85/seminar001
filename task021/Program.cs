// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Distance (double x1, double y1, double x2, double y2)
{
    double Distance1 = Math.Round ( Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)), 2);
    return Distance1;
}
Console.Write("Pls enter x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Pls enter x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance is {Distance (x1, y1, x2, y2)}");