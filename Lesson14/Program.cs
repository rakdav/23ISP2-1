//Тернарная структура выбора
//функция хэвисайда
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double y;
//if (x < 0) y = 0;
//else y = 1;
//Console.WriteLine("y="+y);
//y = (x < 0) ? 0 : 1;
//Console.WriteLine("y=" + y);
//Даны координаты точки и радиус круга с центром в начале координат. Определить, принадлежит ли данная точка кругу
//Console.Write("Введите x:");
//double x=double.Parse(Console.ReadLine());
//Console.Write("Введите y:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите радиус окружности R:");
//double R = double.Parse(Console.ReadLine());
//Console.WriteLine((x*x+y*y<=R*R)?"Принадлежит":"Не принаджлежит");

//Рассчитать значение у при заданном значении х
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//Console.WriteLine($"{((x>0)?Math.Sin(x)*Math.Sin(x):
//    1-2*Math.Sin(x*x)):F2}");

//Даны два различных вещественных числа. Определить:
//а) какое из них больше;
//б) какое из них меньше
//using System;
//Console.Write("Введите a:");
//double a = double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//if (a > b) Console.WriteLine($"{a}>{b}");
//else if (a < b) Console.WriteLine($"{a}<{b}");
//else Console.WriteLine($"{a}={b}");

//Определить максимальное и минимальное значения из двух различных вещественных чисел
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
double max, min;
if(x>y)
{
    max= x; min = y;
}
else 
{ 
    max= y; min = x; 
}
Console.WriteLine($"max={max} min={min}");

