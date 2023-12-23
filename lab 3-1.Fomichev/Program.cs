int N = 5;
double A = 0.0;
double B = 10.0;

double H = (B - A) / N;
double currentPoint = A;

for (int i = 0; i <= N; i++)
{
    Console.WriteLine("Точка " + (i + 1) + ": " + currentPoint);
    currentPoint += H;
}
