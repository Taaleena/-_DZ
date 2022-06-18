System.Console.Write("Введите число:   ");
string param = Console.ReadLine();
int N = Convert.ToInt32(param);
int count = 0;

while (count < N)

{
count++;
System.Console.WriteLine(count * count * count);
}
