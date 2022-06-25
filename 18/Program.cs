int size = new Random().Next(10, 13);

System.Console.WriteLine($"Элементов массива: {size}");

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    { 
               array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    System.Console.WriteLine($"Минимальное значение {arr.Min()}, максимальное значение {arr.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями составляет {difference}");
    System.Console.WriteLine();
}

PrintMinMax(FillSourceArray(size));
