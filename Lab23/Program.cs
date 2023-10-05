//Уровень базовый
//Console.Write("Введите n:");
//int n=int.Parse(Console.ReadLine());
//switch(n)
//{
//    case 1:
//        {
//            int a = 46, b = 74;
//            Console.WriteLine($"Произведение цифр:{a*b}");
//        }
//        break;
//    case 2:
//        {
//            int a = 41, b = 81;
//            Console.WriteLine($"Произведение цифр:{a * b}");
//        }
//        break;
//    case 3:
//        {
//            int a = 39, b = 76;
//            Console.WriteLine($"Произведение цифр:{a * b}");
//        }
//        break;
//    case 4:
//        {
//            int a = 29, b = 53;
//            Console.WriteLine($"Произведение цифр:{a * b}");
//        }
//        break;
//}
//Средний уровень 26
Console.Write("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите n:");
double x = double.Parse(Console.ReadLine());
switch (n)
{
    case 1:
        {
            double z = Math.Asin(x * x * x);
            double y=0;
            if (z > -0.5) y = ((2 * z + 1) * (2 * z + 1)) / (3.71 - x * x);
            else if (z > -0.5 && z <= 1E-3) y = Math.Pow(Math.Sin(z), 3) - Math.Sin(z / 3 * Math.PI);
            else y = (Math.Tan(z + x) - Math.Exp(x)) / (3.5*x);
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 2:
        {
            double z = Math.Acos(x * x * x);
            double y = 0;
            if (z > -0.5) y = ((2 * z + 1) * (2 * z + 1)) / (3.71 - x * x);
            else if (z > -0.5 && z <= 1E-3) y = Math.Pow(Math.Sin(z), 3) - Math.Sin(z / 3 * Math.PI);
            else y = (Math.Tan(z + x) - Math.Exp(x)) / (3.5 * x);
            Console.WriteLine($"y={y:F2}");
        }
        break;
    case 3:
        {
            double z = Math.Tan(x * x * x);
            double y = 0;
            if (z > -0.5) y = ((2 * z + 1) * (2 * z + 1)) / (3.71 - x * x);
            else if (z > -0.5 && z <= 1E-3) y = Math.Pow(Math.Sin(z), 3) - Math.Sin(z / 3 * Math.PI);
            else y = (Math.Tan(z + x) - Math.Exp(x)) / (3.5 * x);
            Console.WriteLine($"y={y:F2}");
        }
        break;
}