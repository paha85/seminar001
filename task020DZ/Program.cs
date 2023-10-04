// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.

double Distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double Distance1 = Math.Round ( Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);
    return Distance1;
}
Console.Write("Pls enter x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter y1: ");
double z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Pls enter x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Pls enter y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
double z2 = Convert.ToInt32(Console.ReadLine());



Console.WriteLine($"Distance is {Distance (x1, y1, z1, x2, y2, z2)}");

