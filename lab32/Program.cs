//Начальный уровень 26 вариант
//int i = 100;
//while (i <= 200)
//{
//    if (i % 2 != 0) Console.Write(i+" ");
//    i++;
//}
//Средний уровень 26 вариант
//int i = 100;
//while(i<=999)
//{
//    int a=i/100;
//    int b = i / 10 % 10;
//    int c=i%10;
//    if(a==b&&b==c) Console.Write(i+" ");
//    i++;
//}
//высокий уровень вариант 26
try
{
    Console.Write("Введите число:");
    long n=long.Parse(Console.ReadLine());
    long temp = n;
    while (temp != 0)
    {
        long m = temp % 10;
        long k = temp;
        int count = 0;
        int step = 1;
        long newShislo = 0;
        while (k!=0) 
        {
            if (k % 10 == m) count++;
            else 
            {
                newShislo += k % 10 * step;
                step *= 10;
            }
            k/=10;
        }
        Console.WriteLine($"Число {m} встречается {count} раз");
        temp =newShislo;
        Console.WriteLine(temp);
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}