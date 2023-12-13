Drob a = new Drob(4, 6);
Drob b= new Drob(3, 5);
Console.WriteLine(a.ToString());
Console.WriteLine(b.ToString());
Drob c=a.Add(b);
Console.WriteLine(c.ToString());
Drob d = a.Sub(b);
Console.WriteLine(d.ToString());
Drob e = a.Mult(b);
Console.WriteLine(e.ToString());
Drob f = a.Div(b);
Console.WriteLine(f.ToString());
class Drob
{
    public int A { get; set; }
    public int B { get; set; }
    public Drob(int a, int b)
    {
        A = a;
        B = b;
    }
    public Drob(int a):this(a, 1) { }
    public Drob(Drob d):this(d.A,d.B) { }//конструктор копирования
    public Drob Add(Drob d)
    {
        int ch=this.A*d.B+this.B*d.A;
        int zn = this.B * d.B;
        return new Drob(ch, zn);
    }
    public Drob Sub(Drob d)
    {
        int ch = this.A * d.B - this.B * d.A;
        int zn = this.B * d.B;
        return new Drob(ch, zn);
    }
    public Drob Mult(Drob d)
    {
        int ch = this.A * d.A;
        int zn = this.B * d.B;
        return new Drob(ch, zn);
    }
    public Drob Div(Drob d)
    {
        int ch = this.A * d.B;
        int zn = this.B * d.A;
        return new Drob(ch, zn);
    }

    public override string? ToString()
    {
        return $"{A}/{B}";
    }
}
