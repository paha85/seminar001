// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int Coefficient = 0;
const int Constant = 1;
const int x_cord = 0;
const int y_cord = 1;
const int line1 = 1;
const int line2 = 2;

double[] lineData1 = InputLineData(line1);
double[] lineData2 = InputLineData(line2);

if (ValidateLines(lineData1, lineData2)){
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($" dot is y={lineData1[Coefficient]} * x + {lineData1[Constant]} and y={lineData2[Coefficient]} * x +{lineData2[Constant]}");
    Console.WriteLine($" have coordinates ({coord[x_cord]}, {coord[y_cord]})");

}

double Promt(string message){
    Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double[] InputLineData(int numberOfLine){
    double[] lineData = new double[2];
    lineData[Coefficient] = Promt($"Enter coef for {numberOfLine} >");
    lineData[Constant] = Promt($" Enter const for {numberOfLine} >");
    return lineData;
}
double[] FindCoords(double[] lineData1, double[] lineData2){
    double[] coord = new double[2];
    coord[x_cord] = (lineData1[Constant] - lineData2[Constant]) / (lineData2[Coefficient] - lineData1[Coefficient]);
    coord[y_cord] = lineData1[Constant] * coord[x_cord] + lineData1[Constant];
    return coord;
}

bool ValidateLines(double[] lineData1, double[] lineData2){
    if (lineData1[Coefficient] == lineData2[Coefficient]){
        if (lineData1[Constant] == lineData2[Constant]){
            Console.WriteLine("sovpadayut");
            return false;
        }
        else{
            Console.WriteLine("paralelni");
            return false;
        }
    }
    return true;
}