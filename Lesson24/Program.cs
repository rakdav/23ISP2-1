//double a = 5;
//for (int i = 0;i<5;i++)
//{
//    Console.WriteLine(a);
//    a += 2;
//}
//for(int i=35;i<=87;i++)
//{
//    if(i%7==1||i%7==2||i%7==5)
//        Console.Write(i+" ");
//}
//Console.WriteLine();
//Console.Write("Введите n:");
//int n=int.Parse(Console.ReadLine());
//int s = 0;
//for (int i = 1; i <= n; i++) s += i;
//Console.WriteLine($"Sum={s}");
//long F = 1;
//for (int i = 1;i <= n; i++) F *= i;
//Console.WriteLine($"Fact={F}");
//5.1
for (int i = 0; i < 10; i++)
{
    Console.Write(20+" ");
}
Console.WriteLine();
//5.2
Console.Write("Введите число:");
int m=int.Parse(Console.ReadLine());
Console.Write("Введите количесвто повторений:");
int n = int.Parse(Console.ReadLine());
for (int i = 0;i<n;i++)
    Console.Write(m+" ");