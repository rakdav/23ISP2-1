char[] mas = Console.ReadLine().ToCharArray();
int count = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i]==' ') count++;
}
char[][] result = new char[count + 1][];
int n = 0;
int last = 0;
int k = 0;
for (int i = 0;i < mas.Length; i++)
{
    if (mas[i]!=' '||i==mas.Length-1) k++;
    else
    {
        result[n]=new char[k];
        for (int j = last; j < k; j++) result[n][j] = mas[j];
        n++;
        last = k + 1;
        k = 0;
    }
}
for (int i = 0; i < result.Length; i++)
{
    for (int j = 0; j < result[i].Length; j++)
    {
        Console.Write($"{result[i][j]} \t");
    }
    Console.WriteLine();
}