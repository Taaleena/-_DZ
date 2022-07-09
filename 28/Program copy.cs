int row = 3;
int col = 3;

int[,] matrix1 = CreateMatrix(row, col, 1, 5);
int[,] matrix2 = CreateMatrix(row, col, 6, 10);
int[,] result = MultiplyMatrix(matrix1, matrix2);


int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
             
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {

            product[i, k] += matrix1[i, j] * matrix2[k, j];
            }
        }
    }
    return product;
}

//2*4+0*3+1*0




void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}


PrintMatrix(matrix1);
System.Console.WriteLine("---");
PrintMatrix(matrix2);
System.Console.WriteLine("---");
PrintMatrix(result);