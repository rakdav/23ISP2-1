//базовый уровень 27
Console.Write("Введите текущее время:");
int h=int.Parse(Console.ReadLine());
if(h>=0&&h<=12) Console.WriteLine("pm");
else if(h>12&&h<24)Console.WriteLine("am");
else Console.WriteLine("Такого времени нет");
//средний уровень 26
Console.Write("Ввести a:");
double a=double.Parse(Console.ReadLine());
Console.Write("Ввести b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Ввести c:");
double c = double.Parse(Console.ReadLine());
double avg = (a + b + c) / 3;
Console.WriteLine($"Среднее арифметическое:{avg:F2}");
if (Math.Abs(a)>avg) Console.WriteLine(a);
if (Math.Abs(b) > avg) Console.WriteLine(b);
if (Math.Abs(c) > avg) Console.WriteLine(c);
//высокий уровень 27
const double c1 = 50E-12;
const double c2 = 500E-12;
const double L = 20E-6;
double d1=2*Math.PI*3E8*Math.Sqrt(c1*L);
double d2 = 2 * Math.PI * 3E8 * Math.Sqrt(c2 * L);
Console.Write("Ввести d:");
double d = double.Parse(Console.ReadLine());
if (d > d1 & 7d < d2) Console.WriteLine("Попадает");
else Console.WriteLine("Не попадает");
