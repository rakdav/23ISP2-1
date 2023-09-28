//базовый уровень 27
//Console.Write("Введите x:");
//double x=double.Parse(Console.ReadLine());
//Console.WriteLine("Введите y:");
//double y=double.Parse(Console.ReadLine());
//Console.WriteLine((x>3)||(x<=-1));
//Console.WriteLine((y>-4&&y<=2)&&(x>0));
//средний уровень 27
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите c:");
double c = double.Parse(Console.ReadLine());
double d = b * b - 4 * a * c;
Console.WriteLine(a<0&&d>0);
//высокий уровень 27
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine((x>=-1&&y<=-x&&y>=0)||(y<=x&&x<=1&&y>=0));