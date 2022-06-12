int Number = new Random().Next(100, 1000);
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();


System.Console.WriteLine($"Рандомное число {Number}");
System.Console.WriteLine($"Если удалить вторую цифру, получится число {NewNumber}");