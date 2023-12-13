//string? name=null;
//string text=name ?? "Tom";
//Console.WriteLine(text);
try
{
    Console.Write("Введите координату x первого вектора:");
    double x1=double.Parse(Console.ReadLine()!);
    Console.Write("Введите координату y первого вектора:");
    double y1 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координату x второго вектора:");
    double x2 = double.Parse(Console.ReadLine()!);
    Console.Write("Введите координату y второго вектора:");
    double y2 = double.Parse(Console.ReadLine()!);
    Vector2D v1=new Vector2D(x1,y1);
    Vector2D v2=new Vector2D(x2,y2);
    Console.WriteLine($"{v1}={v1.Length():F2}");
    Console.WriteLine($"{v2}={v2.Length():F2}");
    v1.Add(v2);
    Console.WriteLine($"{v1}={v1.Length():F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Vector2D
{
    public double X { get; set; } 
    public double Y { get; set; }
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }
    public Vector2D(double x) : this(x, 0){ }
    public Vector2D(Vector2D v):this(v.X, v.Y) { }
    public double Length()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
    public void Add(Vector2D v)
    {
        X += v.X;
        Y += v.Y;
    }
    public override string? ToString()
    {
        return $"({X:F1}, {Y:F1})";
    }
}

