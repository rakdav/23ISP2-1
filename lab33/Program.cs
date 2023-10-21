//Вариант 26
//try
//{
//    Console.Write("Введите x:");
//    double x=double.Parse(Console.ReadLine());
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1; i <= n; i++)
//        s += Math.Pow(x, i) * Math.Sin(i * Math.PI / 3) / i;
//    Console.Write($"S={s:F2}");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//вариант 27
try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    double s = 1;
    for (int i = 1; i <= n; i++)
    {
        long f = 1;
        for (int j = 1; j <= i; j++) f *= j;
        if (i % 2 == 0)
        {
            s += Math.Sin(i * Math.PI / 4) / f;
        }
        else
        {
            s -= Math.Sin(i * Math.PI / 4) / f;
        }
    }
    Console.Write($"S={s:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}