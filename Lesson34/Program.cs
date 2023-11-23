//10.1 а
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

//int a = 6,b= 8;
//Console.WriteLine(a+" "+b);
//Swap(a,b);
//Console.WriteLine(a + " " + b);
//SwapRef(ref a,ref b);
//Console.WriteLine(a + " " + b);
//try
//{
//    Console.Write("Введите n:");
//    int n =int.Parse(Console.ReadLine());
//    long fact;
//    Factorial(n, out fact);
//    Console.WriteLine("Factorial=" + fact);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.Write("Введите m");
//int m;
//int.TryParse(Console.ReadLine(), out m);
//Console.WriteLine(2*m);
//Print(in m);
//void Print(in int n)//входной параметр in
//{
//    //n = 9;
//    for (int i = 0; i < n; i++) Console.Write("*");
//}

//void Factorial(int n,out long fact)//выходной параметр out
//{
//    fact = 1;
//    for(int i=1;i<=n;i++) fact *= i;
//}
//void Swap(int x,int y)//параметры передаются по значению
//{
//  //  Console.WriteLine(x + " " + y);
//    int temp=x; x=y; y=temp;
//  //  Console.WriteLine(x+" "+y);
//}
//void SwapRef(ref int x,ref int y)//передача параметров по ссылке ref
//{
//    int temp=x; x=y;y=temp;
//}

//using System.ComponentModel;

///double x=((Math.Sqrt(6)+6)/2)+((Math.Sqrt(13)+13)/2)+((Math.Sqrt(21)+21)/2);
///

//передача массива в качестве параметра функции
//Random random=new Random();
//int[] mas=new int[random.Next(10,21)];
//for(int i=0;i<mas.Length;i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i]+" ");
//}
//Console.WriteLine();
//SortMas(mas);
//for (int i = 0; i < mas.Length; i++)
//{
//    Console.Write(mas[i]+" ");
//}
///*int[]*/void SortMas(int[] mas)
//{
//    for (int i = 0; i <mas.Length-1; i++)
//    {
//        for (int j = i+1; j < mas.Length; j++)
//        {
//            if (mas[i] > mas[j])
//            {
//                int temp = mas[i];
//                mas[i] = mas[j];
//                mas[j] = temp;
//            }
//        }
//    }
// //   return mas;
//}

//Массив параметров
//void Sum(params int[] numbers)
//{
//    int result = 0;
//    foreach (int number in numbers) result+= number;
//    Console.WriteLine("Sum="+result);
//}
//void Mult(int n, params int[] numbers)
//{
//    int mult = n;
//    foreach (int number in numbers) mult *= number;
//    Console.WriteLine(mult);
//}
//int[] mas = { 1, 5, 7, 4, 7, 9, 8 };
//Sum(mas);
//Sum(1, 4, 83, 6, 3, 7, 4, 8);
//Mult(10, 8, 57, 9, 7, 94, 3);

//рекурсия
//long Fact(int n)
//{
//    long F = 1;
//    for (int i = 1; i <= n; i++) F *= i;
//    return F;
//}
//long FactRecursive(int n)
//{
//    if(n==0||n==1) return 1;
//    return n * FactRecursive(n - 1);
//}

//int Primer1(int n)
//{
//    if(n==0) return 0;
//    else if(n%2==0) return Primer1(n/2);
//    else return 1+Primer1(n-1);
//}
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Console.WriteLine(Fact(n));
//    Console.WriteLine(FactRecursive(n));
//    Console.WriteLine(Primer1(n));
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//возвращение значения из switch
//int DoOperation(int a,int b,int op)
//{
//    switch (op)
//    {
//        case 1:return a + b;
//        case 2:return a - b;
//        case 3:return a * b;
//        case 4: if(b!=0) return a / b;
//                return 0;
//        default: return 0;
//    }
//}
//int DoOperatorSwitch(int a, int b, int op)
//{
//    return op switch
//    {
//        1 => a + b,
//        2 => a - b,
//        3 => a * b,
//        4 => (b!=0)?a / b:0,
//        _ => 0
//    };
//}
//try
//{
//    Console.Write("Введите x:");
//    int x = int.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    int y = int.Parse(Console.ReadLine());
//    Console.WriteLine(DoOperation(x,y,new Random().Next(1,6)));
//    Console.WriteLine(DoOperatorSwitch(x, y, new Random().Next(1, 6)));
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//локальные функции
void Compare(int[] mas1, int[] mas2)
{
    //int s1 = 0;
    //foreach (int i in mas1)
    //    s1 += i;
    //int s2 = 0;
    //foreach (int i in mas2)
    //    s2 += i;
    int s1=Sum(mas1); int s2=Sum(mas2);
    if (s1 > s2) Console.WriteLine($"{s1}>{s2}");
    else if (s1 < s2) Console.WriteLine($"{s1}<{s2}");
    else Console.WriteLine($"{s1}={s2}");
    int Sum(int[] mas)
    {
        int sum = 0;
        foreach (int i in mas)
            sum += i;
        return sum;
    }
}
int[] mas1 = new int[new Random().Next(5, 11)];
int[] mas2 = new int[new Random().Next(5, 11)];
for (int i = 0; i < mas1.Length; i++)
{
    mas1[i]=new Random().Next(10,100);
}
for (int i = 0; i < mas2.Length; i++)
{
    mas2[i] = new Random().Next(10, 100);
}
Compare(mas1, mas2);