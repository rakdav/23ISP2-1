//базовый 30
//1
//Console.WriteLine("Введите  1 время в формате hh:mm:ss:");
//string str1=Console.ReadLine();
//TimeOnly t1=TimeOnly.Parse(str1);
//Console.WriteLine("Введите  2 время в формате hh:mm:ss:");
//string str2 = Console.ReadLine();
//TimeOnly t2 = TimeOnly.Parse(str2);
//if(t1<t2) Console.WriteLine($"{t1}<{t2}");
//else if(t1>t2) Console.WriteLine($"{t1}>{t2}");
//else Console.WriteLine($"{t1}={t2}");

//2
//Console.WriteLine("Введите дату посkедней профилактики в формате yyyy.MM.dd:");
//DateOnly d = DateOnly.Parse(Console.ReadLine());
//Console.WriteLine("Введите периодичность:");
//int p=int.Parse(Console.ReadLine());
//Console.WriteLine(d.AddMonths(p));

//средний уровень

try
{
    Console.Write("Введите количество пунктов расписания:");
    int n=int.Parse(Console.ReadLine());
    SmartHouse[] smartHouse = new SmartHouse[n];
    for(int i=0; i<n; i++)
    {
        smartHouse[i] = new SmartHouse();
        Console.Write("Введите дату в формате YYYY-MM-DD:");
        smartHouse[i].data=DateOnly.Parse(Console.ReadLine());
        Console.Write("Введите время в формате hh-mm-ss:");
        smartHouse[i].time = TimeOnly.Parse(Console.ReadLine());
        Console.Write("Введите режим:");
        smartHouse[i].mode = Console.ReadLine();
        Console.Write("Введите температуру:");
        smartHouse[i].temp = double.Parse(Console.ReadLine());
    }
    foreach (SmartHouse item in smartHouse)
    {
        TimeOnly nowTime = TimeOnly.FromDateTime(DateTime.Now);
        DateOnly nowDate=DateOnly.FromDateTime(DateTime.Now);
        if(item.time>nowTime)
        {
            Console.WriteLine(item.mode+" "+(item.time.Minute-nowTime.Minute));
        }
        if (item.data == nowDate.AddDays(1))
        {
            Console.WriteLine(item.mode);
        }
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct SmartHouse
{
    public DateOnly data;
    public TimeOnly time;
    public string mode;
    public double temp;
}
