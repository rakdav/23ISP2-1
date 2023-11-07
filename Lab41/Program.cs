//вариант 26 базовый
//double[] mas=new double[15];
//Random random=new Random();
//double P1=1,P2=1;
//for (int i = 0;i<mas.Length;i++)
//{
//    mas[i]=random.NextDouble()*100;
//    Console.Write(mas[i]+" ");
//    if (mas[i]>=0) P1 *= mas[i];
//    else P2 *= Math.Abs(mas[i]);
//}
//Console.WriteLine($"R={P1-P2}");

//вариант 26 средний
//double[] mas1=new double[12];
//double[] mas2=new double[12];
//Random rand = new Random();
//for (int i = 0; i<mas1.Length;i++)
//{
//    mas1[i]=Math.Round(rand.NextDouble()*10,1);
//    mas2[i]= Math.Round(rand.NextDouble() * 10,1);
//}
//foreach(double i in mas1) Console.Write($"{i:F2} ");
//Console.WriteLine();
//foreach (double i in mas2) Console.Write($"{i:F2} ");
//Console.WriteLine();
//for (int i = 0;i<mas1.Length;i++)
//{
//    for (int j = 0; j <mas2.Length; j++)
//    {
//        if (mas1[i] == mas2[j]) mas1[i] = 0;
//    }
//}
//foreach (double i in mas1) Console.Write($"{i:F2} ");

//вариант 26 высокий
//Console.Write("Введите размер массива:");
//int n=int.Parse(Console.ReadLine());
//int[] mas=new int[n];
//Random rnd=new Random();
//for(int i=0; i<mas.Length; i++)
//{
//    mas[i]=rnd.Next(10,100);
//    Console.Write(Convert.ToString(mas[i],2)+" ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] += 10;
//    Console.Write(Convert.ToString(mas[i], 2) + " ");
//}
    double dec = 6.8;
    string str1 = "";
    while (dec > 0)
    {
        str1 = String.Concat(Convert.ToString(dec % 2), str1);
        dec = Math.Truncate(dec / 2);
    }
string str2 = "";
int c;
int n = 0;
while (n < 3)
{

    dec *= 2;
    c = Convert.ToInt32(Math.Truncate(dec));
    str2 = String.Concat(str2, Convert.ToString(c));
    dec -= c;
    n++;
}
Console.WriteLine(str1+"."+str2);
