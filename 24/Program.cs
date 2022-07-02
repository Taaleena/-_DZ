int m = 6;
int n = 3;
int min = 1;
int max = 100;

int[,] Array2(int m, int n)
{
    int[,] table = new int[m, n];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(min, max);
        }
    }
    return table;
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            System.Console.Write(tab[i, j] + "    ");
        }
        System.Console.WriteLine();
    }
}

int[,] TableInt = Array2(m, n);
PrintTable(TableInt);


int[] GetArithmeticMean(int[,] array)
{
    int[] result = new int[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            result[j] = sum / array.GetLength(1);
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("------------------------");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}



int[,] matrix = Array2(m, n);
PrintTable(matrix);
int[] arithmeticMean = GetArithmeticMean(matrix);
PrintArray(arithmeticMean);