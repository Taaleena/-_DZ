int size = 10;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {   
                array[i] = new Random().Next(100, 1000);
        }
    return array;
}

void PrintResult(int[] array)
{
    int chet = 0;
    int nechet = 0;
    for (int i = 0; i < array.Length; i++)
    {      
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) chet++;
        else nechet++;
    }
    Console.WriteLine();
    System.Console.WriteLine($"Количество четных чисел {chet}, количество нечетных чисел {nechet}");
   
    
}


    PrintResult(FillArray(size));