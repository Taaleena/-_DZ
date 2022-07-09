int m = 1;
int n = 6;


int Sum (int m, int n)
{

if (m > n) return 0;


return Sum (m, n-1)+n;

}

int i = Sum (m, n);

System.Console.WriteLine();
Console.WriteLine($"сумма  {i}");






// int Sum (int m, int n, int i)
// {

// if (m > n) 
// {
//    Console.WriteLine (m + " ");
//    i = i + m;
//    m++;
   
   
//  return
//   Sum (m, n, i); 
//    }
// return i;
// }

//  Sum (m, n, i);

// System.Console.WriteLine();
// Console.WriteLine($"сумма  {Sum}");
