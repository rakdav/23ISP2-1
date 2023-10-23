//Базовый 26
//double x = 0.1;
//Console.ForegroundColor = ConsoleColor.Red;
//Console.WriteLine("|    x   |   y    |");
//Console.ForegroundColor = ConsoleColor.White;
//while (x<=3)
//{
//    double y=Math.Sqrt(1+x)-3*Math.Cos(x);
//    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
//    x += 0.2;
//}

//средний 26
//Console.WriteLine("|    x   |   y    |");
//for (double x = -Math.PI;x<=Math.PI/2;x+=0.2)
//{
//    double y;
//    if (x < 0) y = Math.Log(Math.Abs(Math.Sin(x * x)));
//    else if (x >= 0 && x <= 2.5) y = Math.Pow(x, 5);
//    else y = x + 1;
//    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
//}

//высокий 26
Console.WriteLine("|    x   |   y    |");
for (double x = -Math.PI/2; x <=2*Math.PI; x += Math.PI/4)
{
    double y;
    if (x <= Math.PI) y = Math.Pow(Math.Asin(1-Math.Abs(Math.Cos(x*x*x))), Math.Sin(x));
    else y=Math.Log(Math.Cos(x));
    Console.WriteLine($"|{x,8:F2}|{y,8:F2}|");
}
