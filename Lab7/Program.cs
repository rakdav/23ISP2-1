//базовый уровень
//try
//{
//    Console.Write("Введите количество компьютеров:");
//    int n = int.Parse(Console.ReadLine());
//    Computer[] computers = new Computer[n];
//    for (int i = 0; i < n; i++)
//    {
//        computers[i] = new Computer();
//        Console.Write("Введите название компьютера:");
//        computers[i].Name = Console.ReadLine();
//        Console.Write("Введите частоту:");
//        computers[i].Frequency = double.Parse(Console.ReadLine());
//        Console.Write("Введите размер оперативной памяти:");
//        computers[i].RAM = int.Parse(Console.ReadLine());
//        Console.WriteLine("Есть ли DVD-ROM(y/n)?");
//        char dvd = char.Parse(Console.ReadLine());
//        if (dvd == 'y') computers[i].DVD = true;
//        else computers[i].DVD = false;
//        Console.Write("Введите стоимость:");
//        computers[i].Cost = decimal.Parse(Console.ReadLine());
//    }
//    foreach(Computer computer in computers)
//    {
//        if (computer.DVD == true)
//        {
//            Console.WriteLine(computer.Name);
//            Console.WriteLine(computer.Frequency);
//            Console.WriteLine(computer.RAM);
//            Console.WriteLine(computer.Cost);
//        }
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//struct Computer
//{
//    public string Name;
//    public double Frequency;
//    public int RAM;
//    public bool DVD;
//    public decimal Cost;
//}

//средний уровень
try
{
    Console.Write("Введите количество автомобилей:");
    int n = int.Parse(Console.ReadLine());
    Car[] cars = new Car[n];
    for (int i = 0; i < n; i++)
    {
        cars[i] = new Car();
        Console.Write("Введите марку:");
        cars[i].Marka = Console.ReadLine();
        Console.Write("Введите производителя:");
        cars[i].Factory = Console.ReadLine();
        Console.Write("Введите тип:");
        cars[i].Type = Console.ReadLine();
        Console.Write("Введите год выпуска:");
        cars[i].Year =int.Parse(Console.ReadLine());

        Console.Write("Введите год техосмотра:");
        int year=int.Parse(Console.ReadLine());
        Console.Write("Введите месяц техосмотра:");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Введите день техосмотра:");
        int day = int.Parse(Console.ReadLine());
        cars[i].DateTech=new DateTime(year, month, day);

        Console.Write("Введите год регистрации:");
        int yearReg = int.Parse(Console.ReadLine());
        Console.Write("Введите месяц регистрации:");
        int monthReg = int.Parse(Console.ReadLine());
        Console.Write("Введите день регистрации:");
        int dayReg = int.Parse(Console.ReadLine());
        cars[i].DateReg = new DateTime(year, month, day);
    }
    foreach (Car car in cars)
    {
        int nowYear=DateTime.Now.Year;
        int toYear=car.DateTech.Year;
        if(nowYear-toYear<1) 
        {
            Console.WriteLine(car.Marka);
            Console.WriteLine(car.Factory);
            Console.WriteLine(car.Type);
            Console.WriteLine(car.Year);
            Console.WriteLine(car.DateTech);
            Console.WriteLine(car.DateReg);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

struct Car
{
    public string Marka;
    public string Factory;
    public string Type;
    public int Year;
    public DateTime DateTech;
    public DateTime DateReg;
}
