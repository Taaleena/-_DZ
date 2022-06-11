        int a, b;
 
        Console.WriteLine("Введите последовательно два числа : ");
 
        a = Convert.ToInt32(Console.ReadLine());
 
        b = Convert.ToInt32(Console.ReadLine());
 
        if (a > b)
 
        {
 
            Console.WriteLine("{0} большее число", a);
            Console.WriteLine("{0} меньшее число", b);
 
        }
 
        else
 
        {
 
            Console.WriteLine("{0} большее число ", b);
            Console.WriteLine("{0} меньшее число ", a);
 
        }
