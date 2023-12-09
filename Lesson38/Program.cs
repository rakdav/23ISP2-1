//try
//{
//    Console.Write("Введите радиус:");
//    double radius = double.Parse(Console.ReadLine());
//    Console.Write("Введите высоту:");
//    double height = double.Parse(Console.ReadLine());
//    Cylinder cylinder=new Cylinder(radius, height);
//    cylinder.Print();
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
try
{
    Console.Write("Введите название:");
    string name = Console.ReadLine();
    Console.Write("Введите цену:");
    decimal price = decimal.Parse(Console.ReadLine());
    Console.Write("Введите производителя:");
    string factory = Console.ReadLine();
    Product product1=new Product(name,price,factory);
    product1.Print();
    Console.Write("Введите курс доллара:");
    decimal kurs=decimal.Parse(Console.ReadLine());
    Console.WriteLine($"Цена в долларах:{product1.toDollars(kurs)}");
    product1.ToyotaMoney();
    Console.WriteLine($"Цена в долларах:{product1.toDollars(kurs)}");
}
catch (Exception ex)
{

}
class Product
{
    private string name;
    private decimal price;
    private string factory;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public decimal Price
    {
        get { return price; }
        set { if (value >= 0) price = value;
            else price = 0;
        }
    }
    public string Factory
    {
        get { return factory; }
        set { factory = value; }
    }

    public Product(string name, decimal price, string factory)
    {
        this.Name = name;
        this.Price = price;
        this.Factory = factory;
    }
    public decimal toDollars(decimal kurs)
    {
        return kurs*price;
    }
    public void ToyotaMoney()
    {
        if (Name.Contains("Toyota"))
            price = price * (decimal)1.2;
    }
    public void Print()
    {
        Console.WriteLine( $"Название:{Name} Цена:{Price} " +
            $"Производитель:{Factory}" );
    }
}

class Cylinder
{
    private double radius;
    private double height;
    public double Radius
    {
        get { return radius; } 
        set {radius = value; } 
    }
    public double Height
    {
        get { return height; }
        set { height = value; }
    }
    public Cylinder(double radius, double height)
    {
        this.radius = radius;
        this.height = height;
    }
    public double getArea()
    {
        return 2 * Math.PI * radius * height + 2 * Math.PI*radius*radius;
    }
    public void Print()
    {
        Console.WriteLine($"Радиус:{radius} Высота:{height} Площадь:{getArea():F2}");
    }
}
