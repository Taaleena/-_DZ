int volume = 5;                // колчествопредложений ввода
int count = 0;

while (volume > 0)
{
    System.Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}

System.Console.WriteLine($"Чисел больше 0: {count}");