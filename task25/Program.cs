// принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double PowLite(double a, double b) 
{
    double resultF = 1;
    for(int i = 1; i <= b; i++)
    {
        resultF = resultF * a;
    }
    return resultF;
}

Console.WriteLine("Enter а integer number ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Enter a degree ");
double b = double.Parse(Console.ReadLine());

double resultP = PowLite(a, b);
Console.WriteLine($"{a} ^ {b} = {resultP}");

// double resultP2 = Math.Pow(a, b);
// Console.WriteLine(resultP2);