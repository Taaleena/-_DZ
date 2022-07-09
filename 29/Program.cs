int m = 1;
int n = 6;

void Numbers (int m, int n)
{

if (m > n) return;
if (n % 2 == 1)
{
    n--;
}
Numbers (m, n-2);
System.Console.Write($"{n}; ");
}

Numbers(m, n);
System.Console.WriteLine();





// void Numbers (int m, int n)

// {

// while (m < n)
// {
//     return;


// if (n % 2 == 0) return;
// }

// }

//Console.WriteLine ($"{n}; ");



// return $"{m} " + Numbers(m+ ,n)
//void PrintNumber (int m, int n)

//string Numbers (int m, int n)
// {
//   if (m <= n) return;

// Numbers (m, n-1);
   
//  if (n % 2 == 0) return $"{n} " + Numbers(n+2);


  
//  }
 //System.Console.Write($"{n}; "); 
//
 //Console.Write(m + " ");