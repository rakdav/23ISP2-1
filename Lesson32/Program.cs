//26
//char[,] matrix = new char[4,4];
//Random random=new Random();
//int s = 0;
//for (int i = 0; i < matrix.GetUpperBound(0)+1; i++)
//{
//    for (int j = 0; j < matrix.GetUpperBound(1)+1; j++)
//    {
//        matrix[i,j]=(char) random.Next(65,123);
//        Console.Write(matrix[i,j]+" ");
//        if (i == j) s += (int)matrix[i, j];
//    }
//    Console.WriteLine();
//}
//Console.WriteLine("S="+s);

//27
//char[,] matrix = new char[5, 5];
//Random random = new Random();
//for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
//    {
//        matrix[i, j] = (char)random.Next(65, 123);
//        Console.Write(matrix[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//int max = (int)matrix[0,0];
//for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
//{
//    for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
//    {
//        if ((int)matrix[i, j] > max) max = (int)matrix[i, j];   
//    }
//}
//Console.WriteLine("max="+max);
//28
//Console.Write("Введите размер массива:");
//int n=int.Parse(Console.ReadLine());
//char[] chars = new char[n];
//for (int i = 0; i < n; i++) 
//    chars[i]=char.Parse(Console.ReadLine());
//int count = 0;
//for (int i = 0;i < n; i++)
//    if (chars[i] == '.') count++;
//char[] result = new char[n+2*count];
//count = 0;
//for (int i = 0;i<n; i++)
//{
//    if (chars[i] != '.')
//    {
//        result[count++] = chars[i];
//    }
//    else
//    {
//        result[count++] = '.';
//        result[count++] = '.';
//        result[count++] = '.';
//    }
//}
//for (int i = 0; i < result.Length; i++)
//    Console.Write(result[i]);
Console.Write("Введите строку:");
char[] mas = Console.ReadLine().ToCharArray();
Console.WriteLine((int)'A');
Console.WriteLine((int)'Z');
Console.WriteLine((int)'a');
Console.WriteLine((int)'z');

