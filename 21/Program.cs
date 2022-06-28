
System.Console.Write ("Введите число b1:   ");
string number = Console.ReadLine();
double b1 = Convert.ToInt32(number);

System.Console.Write ("Введите число k1:   ");
string number2 = Console.ReadLine();
double k1 = Convert.ToInt32(number2);

System.Console.Write ("Введите число b2:   ");
string number3 = Console.ReadLine();
double b2 = Convert.ToInt32(number3);

System.Console.Write ("Введите число k2:   ");
string number4 = Console.ReadLine();
double k2 = Convert.ToInt32(number4);


double x (double i)
{
double result = i;
i=(b2 - b1)/(k1 - k2);
return result;
}

double itog (double itogo)
{
double m =k1*x+b1;
double n =k2*x+b2;
double result = itogo;
return result;
}


System.Console.WriteLine($"точка пересечения {itog}");