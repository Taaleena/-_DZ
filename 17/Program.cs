int size = 13;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 50);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    
    for (int i = 0; i < size; i++)
    {
        System.Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма чисел на нечетной позиции - {sum} ");
   
}

PrintArray(FillArray(size));