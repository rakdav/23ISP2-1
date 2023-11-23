using ClassLibraryLab62;
try
{
    Console.Write("Введите n:");
    int n=int.Parse(Console.ReadLine());
    Console.Write("Введите m:");
    int m = int.Parse(Console.ReadLine());
    int[,] mas=new int[n,m];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            mas[i, j] = new Random().Next(-100, 100);
            Console.Write(mas[i,j]+" ");
        }
        Console.WriteLine();
    }
    int[] result = ClassLibraryLab62.ClassLib.Negative(mas);
    for (int i = 0;i < result.Length; i++) 
    {
        Console.Write(result[i]+" ");
    }
    Console.WriteLine();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
