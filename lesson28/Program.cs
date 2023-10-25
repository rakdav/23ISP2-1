//обьявление массивов
//инициализация при обьявлении
int[] mas1 = { 1, 3, 5, 7, 9 };
int[] mas2 = new int[5] {2,4,6,8,10};
//ввод с клавиатуры
int[] mas3 = new int[5];
for (int i = 0; i < mas3.Length; i++)
{
    mas3[i]=int.Parse(Console.ReadLine());
}
//вывод с помощью оператора for
for (int i = 0;i<mas3.Length; i++)
{
    Console.Write(mas3[i]+" ");
}
Console.WriteLine();
//генерация элементов массива с помощью генератора случайных чисел
Random random=new Random();
int[] mas4 = new int[10];
for (int i = 0; i < mas4.Length; i++)
{
    mas4[i] = random.Next(10, 100);
    Console.Write(mas4[i]+" ");
}
Console.WriteLine();
//генерация вещественных чисел
double[] mas5 = new double[10];
for (int i = 0;i < mas5.Length; i++)
{
    mas5[i]=100*random.NextDouble();
    Console.Write($"{mas5[i]:F2} ");
}
Console.WriteLine();
//генерация по формуле
int[] mas6 = new int[10];
for (int i = 0; i < mas6.Length; i++)
{
    mas6[i] = 2 * i + 1;
}
//вывод с помощью цикла foreach
foreach (int i in mas6)
{
    Console.Write(i+" ");
}
Console.WriteLine();