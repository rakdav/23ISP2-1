//Console.Write("Введите номер дня недели:");
//int n=int.Parse(Console.ReadLine());
//switch(n)
//{
//    case 1: Console.WriteLine("Понедельник");break;
//    case 2: Console.WriteLine("Вторник"); break;
//    case 3: Console.WriteLine("Среда"); break;
//    case 4: Console.WriteLine("Четверг"); break;
//    case 5: Console.WriteLine("Пятница"); break;
//    case 6: Console.WriteLine("Суббота"); break;
//    case 7: Console.WriteLine("Воскресенье"); break;
//    default: Console.WriteLine("Такого дня недели нет");break;
//}
//Console.Write("Введите номер месяца:");
//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 12: case 1: case 2: Console.WriteLine("Зима"); break;
//    case 3: case 4: case 5: Console.WriteLine("Весна"); break;
//    case 6: case 7: case 8: Console.WriteLine("Лето");break;
//    case 9: case 10: case 11: Console.WriteLine("Осень"); break;
//    default: Console.WriteLine("Такого месяца нет"); break;
//}

//if(n>=1&&n<=31) Console.WriteLine("Январь");
//else if(n>=32&&n<=58) Console.WriteLine("Февраль");
//else if (n >= 59 && n <= 90) Console.WriteLine("Март");

Console.Write("Введите сумму:");
int n = int.Parse(Console.ReadLine());
if(n%100>10&&n%100<15) Console.WriteLine(n + " рублей");
else
switch (n%10)
{
    case 1: Console.WriteLine(n+" рубль");break;
    case 2: case 3: case 4: Console.WriteLine(n + " рубля"); break;
    default: Console.WriteLine(n + " рублей"); break;
}