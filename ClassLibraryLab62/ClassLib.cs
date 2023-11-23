namespace ClassLibraryLab62
{
    public class ClassLib
    {
        public static int[] Negative(int[,] mas)
        {
            int[] result=new int[mas.GetLength(0)];
            for(int i=0;i<mas.GetLength(0);i++)
            {
                int count = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < 0) count++;
                }
                result[i] = count;
            }
            return result;
        }
    }
}
