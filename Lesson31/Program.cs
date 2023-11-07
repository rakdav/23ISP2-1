//Console.Write("Введите количество строк:");
//int n=int.Parse(Console.ReadLine());
//Console.Write("Введите количество столбцов:");
//int m = int.Parse(Console.ReadLine());
//int[,] mas1={{1,3,5},
//             {7,9,3}};
//Console.WriteLine(mas1[0, 1]);

//Random r = new Random(); 

//int[,] mas2 = new int[n, m];
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < m; j++)
//    {
//        mas2[i, j] = r.Next(0, 101);
//        Console.Write(mas2[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//12.23а
//int[,] mas3=new int[7, 7];
//for (int i = 0;i < 7; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        if (i == j || j + i == 6) mas3[i, j] = 1;
//        Console.Write(mas3[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
////12.23б
//int[,] mas4 = new int[7, 7];
//for (int i = 0; i < 7; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        if (i == j || j + i == 6||i==3||j==3) mas3[i, j] = 1;
//        Console.Write(mas3[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//12.23в
//int[,] mas5 = new int[7, 7];
//for (int i = 0; i < 7; i++)
//{
//    for (int j = 0; j < 7; j++)
//    {
//        if ((i < j && j + i < 6)||(j<i&&i+j>6)||(i==j)||(i+j==6)) mas5[i, j] = 1;
//        Console.Write(mas5[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//12.24а
//int[,] mas6 = new int[6, 6];
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if (i == 0 || j == 0) mas6[i, j] = 1;
//        else mas6[i, j] = mas6[i, j - 1] + mas6[i - 1, j];
//        Console.Write(mas6[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//12.24б
//int[,] mas7 = new int[6, 6];
//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if (i + j + 1 > 6) mas7[i, j] = i + j - 5;
//        else mas7[i, j] = i + j + 1;
//        Console.Write(mas7[i,j]+" ");
//    }
//    Console.WriteLine();
//}
//12.25а
//int[,] mas8 = new int[12, 10];
//int count = 1;
//for (int i = 0; i < 12; i++)
//{
//    for (int j = 0; j < 10; j++)
//    {
//        mas8[j,i]=count++;
//        Console.Write(mas8[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//12.37
int[,] mas = new int[11, 4];
Random r = new Random();
int s5 = 0;
for (int i = 0; i < 11; i++)
{
    for (int j = 0; j < 4; j++)
    {
        mas[i,j]=r.Next(25, 30);
        Console.Write(mas[i,j]+" ");
        if (i == 4) s5 += mas[i, j];
    }
    Console.WriteLine();
}
Console.WriteLine("CS5="+s5);
