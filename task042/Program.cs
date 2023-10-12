// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

void GetBinaryView(int N){
    if(N == 0){
        return;
    }
    GetBinaryView(N/2);
    Console.Write(N % 2);
}

Console.Write("Pls enter the number: ");
int N = Convert.ToInt32(Console.ReadLine());
GetBinaryView(N);