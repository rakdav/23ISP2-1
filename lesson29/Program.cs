
Console.Write("Введите количество элементов массива:");
int n=int.Parse(Console.ReadLine());
int[] mas=new int[n];
Random r = new Random();
for (int i = 0;i<mas.Length;i++)
{
    mas[i]=r.Next(10,100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
//11.15a
int m = r.Next(mas.Length);
Console.WriteLine($"{mas[m]} {Math.Sqrt(mas[m]):F2}");
//11.15б
int a = r.Next(mas.Length);
int b = r.Next(mas.Length);
Console.WriteLine($"{(mas[a] + mas[b])/2:F2}");
//11.16a
int s=r.Next(mas.Length);
if (mas[s] > 0) Console.WriteLine(">0");
else Console.WriteLine("<0");
//11.16б
int k = r.Next(mas.Length);
if (mas[k]%2==0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");
//11.16в
if (mas[k] > mas[s]) Console.WriteLine($"{mas[k]}>{mas[s]}");
else if (mas[k] < mas[s]) Console.WriteLine($"{mas[k]}<{mas[s]}");
else Console.WriteLine($"{mas[k]}={mas[s]}");
//11.18a
for (int i = 0; i < mas.Length; i++)
{
    mas[i] -= 20;
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
//11.18б
for (int i = 0; i < mas.Length; i++)
{
    mas[i] *= mas[mas.Length-1];
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
//11.19а
int Sum = 0;
for(int i= 0;i< mas.Length; i++)
    Sum += mas[i];
Console.WriteLine("Sum="+Sum);
//11.19б
int P = 1;
for (int i = 0; i < mas.Length; i++)
    P *= mas[i];
Console.WriteLine("P=" + P);
//11.107
int max = mas[0],min = mas[0];
for (int i = 1; i < mas.Length; i++)
{
    if (mas[i] > max) max = mas[i];
    if (mas[i] < min) min = mas[i];
}
Console.WriteLine("max="+max);
Console.WriteLine("min="+min);
Console.WriteLine("max-min="+(max-min));
//сортировка элементов массива
//1. Пузырьком
for (int i = 0; i < mas.Length-1; i++)
{
    for(int j=i+1;j<mas.Length;j++)
    {
        if (mas[i] > mas[j])
        {
            int temp = mas[i];
            mas[i] = mas[j];
            mas[j]=temp;
        }
    }
}
foreach (int i in mas) Console.Write(i+" ");
Console.WriteLine();
