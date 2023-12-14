Cylinders cs=new Cylinders(4,10,3);
cs.Print();
class Cylinder
{
    private double radius;
    private double height;
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
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
        return 2 * Math.PI * radius * height + 2 * Math.PI * radius * radius;
    }
    public void Print()
    {
        Console.WriteLine($"Радиус:{radius} Высота:{height} Площадь:{getArea():F2}");
    }
}
class Cylinders : Cylinder
{
    public int Count { get; set; }
    public Cylinders(double radius, double height,int count) : base(radius, height)
    {
        Count = count;
    }
    public double AllArea()
    {
        return Count*getArea();
    }
    public new void Print()
    {
        Console.WriteLine($"Радиус:{Radius} Высота:{Height} Количество:{Count} Площадь:{AllArea():F2}");
    }
}
