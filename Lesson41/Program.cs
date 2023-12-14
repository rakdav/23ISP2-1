Person person = new Person("Вася", 23);
Console.WriteLine(person);
Employee employee=new Employee("Боря",25,"Samsung");
Console.WriteLine(employee);
class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public Person(string? name,int age)
    {
        Name = name;
        Age = age;
    }
    public override string? ToString()
    {
        return $"Имя:{Name} Возраст:{Age}";
    }
}
class Employee : Person
{
    public string? Company { get; set; }
    public Employee(string? name, int age, string? company) : base(name, age)
    {
        Company = company;
    }

    public override string? ToString()
    {
        return base.ToString()+$" Компания:{Company}";
    }
}
