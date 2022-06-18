System.Console.WriteLine("Введите целое число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// проверка текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}


if (IsPalindrome()) System.Console.WriteLine($"{number} - это палиндром");
else System.Console.WriteLine($" {number} это не палиндром");