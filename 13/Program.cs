
int a = 2;
int b = 8;
int count = 1;
int result = a;

while (count < b)
{
    result = result * a;
    count++;
}

System.Console.WriteLine($"{a} ^ {b} = {result}");
