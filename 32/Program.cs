int n = 8;
int num = 1;



static void sequence (int n, int num)
{
    
    for (int i = 1; i <= n; i++)
    
    if (i == (1+num) * num / 2)
   
    {
        num++;
Console.Write($"{num}, ");
    }
        
}
    sequence (n, num);
    System.Console.Write($"{num}, ");      
        
        
        
        
