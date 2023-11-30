//Person person = new Person();
//Console.Write("Введите фио:");
//person.FIO = Console.ReadLine();
//Console.Write("Введите год рождения:");
//int year=int.Parse(Console.ReadLine());
//Console.Write("Введите месяц рождения:");
//int month = int.Parse(Console.ReadLine());
//Console.Write("Введите день рождения:");
//int day = int.Parse(Console.ReadLine());
//person.dateBirth=new DateTime(year, month, day);
//Console.Write("Введите пол:");
//person.gender=char.Parse(Console.ReadLine());
//Console.Write("Введите рост:");
//person.rost = double.Parse(Console.ReadLine());
//Console.Write("Введите вес:");
//person.weight = double.Parse(Console.ReadLine());
//Console.WriteLine("ФИО:"+person.FIO);
//Console.WriteLine("Дата рождения:" + person.dateBirth);
//Console.WriteLine("Пол:" + person.gender);
//Console.WriteLine("Рост:" + person.rost);
//Console.WriteLine("Вес:" + person.weight);
//struct Person
//{
//    public string FIO;
//    public DateTime dateBirth;
//    public char gender;
//    public double rost;
//    public double weight;
//}
try
{
    Console.Write("Введите количество студентов:");
    int n = int.Parse(Console.ReadLine());
    Student[] students= new Student[n];
    for (int i = 0; i < n; i++)
    {
        students[i] = new Student();
        Console.Write("Введите фио:");
        students[i].fio=Console.ReadLine();
        Console.Write("Введите группу:");
        students[i].group = Console.ReadLine();
        students[i].marks = new int[5];
        for (int j = 0; j < 5; j++)
        {
            students[i].marks[j]=new Random().Next(2,6);
            Console.Write(students[i].marks[j]+" ");
        }
        Console.WriteLine();
    }
    for (int i = 0;i < n-1;i++)
    {

        for (int j = i+1;j<n;j++) 
        {
            if (Avg(students[i].marks)> Avg(students[j].marks))
            {
                Student temp= students[i];
                students[i] = students[j];
                students[j] = temp;
            }
        }
    }
    Console.WriteLine("Отсортрованный по возрастанию среднего бала список:");
    foreach (Student student in students)
    {
        Console.WriteLine(student.fio);
        Console.WriteLine(student.group);
        for (int i = 0; i < student.marks.Length; i++)
        {
            Console.Write(student.marks[i]+" ");
        }
    }
    Console.WriteLine();
    Console.WriteLine("Студенты без троек:");

    foreach (Student student in students)
    {
        bool b = true;
        for (int i = 0; i < student.marks.Length; i++)
        {
            if (student.marks[i]<4) b = false;
        }
        if (b)
        {
            Console.WriteLine(student.fio);
            Console.WriteLine(student.group);
        }
    }
    
}
catch(Exception ex) 
{
    Console.WriteLine(ex.Message);
}

double Avg(int[] mas)
{
    double sum = 0;
    foreach (int item in mas) sum += item;
    return sum / mas.Length;
}
struct Student
{
    public string fio;
    public string group;
    public int[] marks;
}

