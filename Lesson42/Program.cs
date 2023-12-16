Person p = new Person("Vasia", 50, true);
Console.WriteLine(p.Weight());
Employer emp = new Employer("Vasia", 30, true,"Yandex");
Console.WriteLine(emp.Weight());
class Person
{
    public string Name { get; set; }
    private int age;
    public virtual int Age 
    {
        get { return age; }
        set { if (value >= 0 && value <= 100) age = value; }
    }
    public Person(string name,int age,bool meriad)
    {
        Name = name;
        Age = age;
        isMaried = meriad;
    }
    public virtual string Print()
    {
        return $"Имя: {Name}";
    }
    public virtual bool isMaried { get; set; }
    public int Weight()
    {
        return Age + 10;
    }
}
class Employer : Person
{
    public override int Age
    {
        get => base.Age;
        set { if (value > 17 && value < 70) base.Age = value; }
    }
    public string Company { get; set; }
    public Employer(string name,int age, bool meriad, string company) : base(name,age,meriad)
    {
        Company = company;
    }
    public override string Print()
    {
       return base.Print()+$" Компания:{Company}";
    }

    public override sealed bool isMaried => base.isMaried;

    public new int Weight()
    {
        return Age + 10 + 35;
    }
}
