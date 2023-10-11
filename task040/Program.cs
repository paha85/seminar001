// Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.


int Promt(string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

// Promt("Pls entear a: ");
// Promt("Pls entear b: ");
// Promt("Pls entear c: ");

int a = Promt("Pls entear a: ");
int b = Promt("Pls entear b: ");
int c = Promt("Pls entear c: ");

if((a+b>c) && (a+c>b) && (b+c>a)){
    Console.WriteLine("triangle");
}
else{
    Console.WriteLine("not triangle");

}