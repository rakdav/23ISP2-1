//int n = 0;
//do
//{
//    Console.Write("Введите положительное число:");
//    n =int.Parse(Console.ReadLine());
//    if(n<=0) Console.WriteLine("Введите число больше 0");
//}
//while(n<=0);
//int s = 0,i=1;
//do
//{
//    s += i++;
//}
//while(i<=n);
//Console.WriteLine("S=" + s);

//double x = -2;
//Console.WriteLine($"|  {"x",10}  |  {"y",10}  |");
//do
//{
//    double y=Math.Sin(x)*Math.Tan(2*x);
//    Console.WriteLine($"|  {x,10:F2}  |  {y,10:F2}  |");
//    x += 0.5;
//}
//while (x<=2);

//break;
//for (int i = 0; i < 20; i++)
//{
//    if (i == 15) break;
//    Console.Write($"{i} ");
//}
//Console.WriteLine("Цикл завершен...");
////continue
//for (int i = 0; i < 50; i++)
//{
//    if (i%5 == 0) continue;
//    Console.Write($"{i} ");
//}
//Console.WriteLine("Цикл завершен...");

//Организовать беспрерывный ввод чисел с клавиатуры, пока пользователь не введёт 0. После ввода нуля, показать на экран количество чисел, которые были введены, их общую сумму и среднее арифметическое.
//int n;
//int count = 0;
//double sum = 0;
//Console.WriteLine("Введите числа:");
//do
//{
//    n=int.Parse(Console.ReadLine());
//    if (n == 0) break;
//    count++;
//    sum += n;
//} 
//while (n != 0);
//Console.WriteLine($"Количество введеных чисел:{count}");
//Console.WriteLine($"Сумма чисел:{sum}");
//Console.WriteLine($"Среднее арифметическое чисел:{sum/count:F2}");

//Необходимо суммировать все нечётные целые числа в диапазоне, который введёт пользователь с клавиатуры (тремя способами). Организуйте повтор программы.
//Console.Write("Введите нижнюю границу:");
//int low=int.Parse(Console.ReadLine());
//int high;
//do
//{
//    Console.Write("Введите верхнюю границу:");
//    high = int.Parse(Console.ReadLine());
//}
//while (low >= high);
//int sum = 0;
//for (int i = low; i <= high; i++)
//{
//    if (i % 2 != 0) sum+=i;
//}
//Console.WriteLine($"Sum={sum}");
//sum = 0;
//for (int i = low; i <= high; i++)
//{
//    if (i % 2 == 0) continue;
//    sum += i;
//}
//Console.WriteLine($"Sum={sum}");

//Составить программу вычисления значения выражения y=1+1/2+1/3+... +1/20
//double s = 0;
//for (double i = 1; i <= 20; i++)
//    s += 1/i;
//Console.WriteLine($"Sum={s:F2}");

//Найдите все четырехзначные числа, сумма цифр каждого из которых равна 15 
//int i = 1000;
//while (i<=9999)//внешний цикл
//{
//    int temp = i;
//    int s = 0;
//    while (temp != 0) //внутренний цикл
//    {
//        s += temp % 10;
//        temp /= 10;
//    }
//    if (s == 15) Console.Write(i+" ");
//    i++;
//}

//Дано натуральное число. Определить:
//а) количество цифр 3 в нем;
//б) сколько раз в нем встречается последняя цифра;
//в) количество четных цифр в нем. Составное условие и более одного неполного условного оператора не использовать;
//г) сумму его цифр, больших пяти;
//д) произведение его цифр, больших семи;
//е) сколько раз в нем встречаются цифры 0 и 5 (всего).

Console.Write("Введите целое число:");
int n=int.Parse(Console.ReadLine());
int count3 = 0;
int last = n % 10;
int countLast = 0;
int countOdd = 0;
int sumGreate5 = 0;
int multGereate7 = 1;
int count5or7 = 0;
while(n != 0)
{
    int temp = n % 10;
    if(temp==3) count3++;
    if(temp==last) countLast++;
    if(temp%2==0) countOdd++;
    if (temp > 5) sumGreate5 += temp;
    if(temp>7) multGereate7 *= temp;
    if (temp == 5 || temp == 7) count5or7++;
    n/=10;
}


