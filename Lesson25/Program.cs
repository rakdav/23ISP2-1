//int n = 0;
//do
//{
//    Console.Write("Введите положительное число:");
//    n =int.Parse(Console.ReadLine());
//    if(n<=0) Console.WriteLine("Введите число больше 0");
//}
//while(n<=0);
//int s = 0,i=1;
//do
//{
//    s += i++;
//}
//while(i<=n);
//Console.WriteLine("S=" + s);
double x = -2;
Console.WriteLine($"|  {"x",10}  |  {"y",10}  |");
do
{
    double y=Math.Sin(x)*Math.Tan(2*x);
    Console.WriteLine($"|  {x,10:F2}  |  {y,10:F2}  |");
    x += 0.5;
}
while (x<=2);