//базовый уровень 26
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