Console.Write("Введите размер массива:");
int n=int.Parse(Console.ReadLine());
int[] mas=new int[n];
Random rnd=new Random();
for(int i=0; i<mas.Length; i++)
{
    mas[i] = rnd.Next(0, 100);
    Console.Write(mas[i]+" ");
}
Console.WriteLine();
//11.54a
int Sum20 = 0;
for(int i=0;i<mas.Length;i++)
    if (mas[i]<=20) Sum20 += mas[i];
Console.WriteLine("Sum="+Sum20);
//11.54б
Console.Write("Введите a:");
int a = int.Parse(Console.ReadLine());
int Suma = 0;
for (int i = 0; i < mas.Length; i++)
    if (mas[i]>a) Suma += mas[i];
Console.WriteLine("Sum=" + Suma);