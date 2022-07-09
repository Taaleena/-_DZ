int m = 3;
int n = 7;

int Ackermann (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(n - 1));
return Ackermann(m, n);
}

Console.WriteLine($"Функция ({m},{n}) = {Ackermann(m, n)}");