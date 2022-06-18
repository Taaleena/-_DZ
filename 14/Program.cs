
int number = new Random().Next(1, 100);
int sum = 0;
System.Console.Write($"Сумма {number} равна ");

while (number > 0)
{
    int digit = number % 10;
    sum = sum + digit;
    number = number / 10;
}

System.Console.WriteLine(sum);
System.Console.WriteLine();