//10.1 а
///double x=((Math.Sqrt(6)+6)/2)+((Math.Sqrt(13)+13)/2)+((Math.Sqrt(21)+21)/2);
//Console.WriteLine(x);
//x = Drob(6) + Drob(13) + Drob(21);
//Console.WriteLine(x);
//double Drob(int y)
//{
//    return (Math.Sqrt(y)+y)/2;
//}
//10.3a
//Console.Write("Введите а:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//double z = Max(a, 2 * b) * Max(2 * a - b, b);
//Console.WriteLine($"z={z:F2}");
//double Max(double x, double y)
//{
//    if (x > y) return x;
//    return y;
//}

//10.6
//try
//{
//    Console.Write("Введите сторону AB:");
//    double ab = double.Parse(Console.ReadLine());
//    Console.Write("Введите сторону AC:");
//    double ac = double.Parse(Console.ReadLine());
//    Console.Write("Введите сторону CD:");
//    double cd = double.Parse(Console.ReadLine());
//    double bc = Perimetr(ab, ac);
//    double bd = Perimetr(bc, cd);
//    Console.WriteLine($"P={ab + ac + cd + bd:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//double Perimetr(double a,double b)
//{
//    return Math.Sqrt(a*a + b*b);
//}

//10.33
//Print();
//void Print()
//{
//	for (int i = 0; i < 80; i++)
//	{
//        Console.Write("*");
//    }
//}

//10.36
//try
//{
//    Console.Write("Введите количество символов:");
//    int n = int.Parse(Console.ReadLine());
//    Print(n);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//void Print(int n)
//{
//    for (int i = 0; i < n; i++) Console.WriteLine("*");
//}

int a = 6,b= 8;
Console.WriteLine(a+" "+b);
Swap(a,b);
Console.WriteLine(a + " " + b);
SwapRef(ref a,ref b);
Console.WriteLine(a + " " + b);
try
{
    Console.Write("Введите n:");
    int n =int.Parse(Console.ReadLine());
    long fact;
    Factorial(n, out fact);
    Console.WriteLine("Factorial=" + fact);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.Write("Введите m");
int m;
int.TryParse(Console.ReadLine(), out m);
Console.WriteLine(2*m);
Print(in m);
void Print(in int n)//входной параметр in
{
    //n = 9;
    for (int i = 0; i < n; i++) Console.Write("*");
}

void Factorial(int n,out long fact)//выходной параметр out
{
    fact = 1;
    for(int i=1;i<=n;i++) fact *= i;
}
void Swap(int x,int y)//параметры передаются по значению
{
  //  Console.WriteLine(x + " " + y);
    int temp=x; x=y; y=temp;
  //  Console.WriteLine(x+" "+y);
}
void SwapRef(ref int x,ref int y)//передача параметров по ссылке ref
{
    int temp=x; x=y;y=temp;
}
