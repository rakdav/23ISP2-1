//int i = 5;
//while (i > 0)
//{
//    Console.Write(i+" ");
//    --i;
//};
Console.WriteLine("Введите n:");
int n=int.Parse(Console.ReadLine());
int i = 1;
long F = 0;
while (i<=n) F += i++;
Console.WriteLine($"Факториал {n} равен {F}");

