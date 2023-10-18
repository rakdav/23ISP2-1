//Базовый уровень 26 вариант
try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    int temp = n;
    int count;
    for(count=0;temp!=0;count++) temp /= 10;
    temp = n;
    count--;
    int s = 0;
    for(;temp>0;count--)
    {
        int m = temp % 10;
        s+= m*(int)Math.Pow(10,count);
        temp/=10;
    }
    if (s == n) Console.WriteLine("Число симметрично");
    else Console.WriteLine("Число не симметрично");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

//средний уровень 26
try
{
    Console.Write("Введите k:");
    int k=int.Parse(Console.ReadLine());
    double P = 1;
    double S = 0;
    for (int j = 1; j <=k; j++)
    {
        if (j != 3) P *= (j - 6) * j / (j - 3);
        for (int i = j; i <=12; i++)
        {
            if (i != 11) S += Math.Pow(i + 5, 1.0 / 3)/(i-11);
        }
    }
    Console.WriteLine($"P={P * S:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

