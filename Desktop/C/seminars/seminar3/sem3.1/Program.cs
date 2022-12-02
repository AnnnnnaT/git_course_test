double Dest (int x1, int y1, int x2, int y2)

{
    double a = x1 - x2;
    double a2 = Math.Pow(a,2);
    double b = y1 - y2;
    double b2 = Math.Pow(b,2);
    double c = a2 + b2;
    double res = Math.Sqrt(c);
    return res;
}

Console.WriteLine ("Input cordinate x1: ");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine ("Input cordinate y1: ");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine ("Input cordinate x2: ");
int o = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine ("Input cordinate y2: ");
int e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Distance is {Dest(k, h, o, e)}");