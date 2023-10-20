Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32 (Console.ReadLine());
bool IsPalindrome(int number)
{ 
    if (number < 10000 || number > 99999)
       {
       Console.WriteLine("Число не пятизначное");
       return false;
       }
    else
    {
      if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 / 10)
        {
         return true;
        }
     return false;
    }
}   

   Console.WriteLine(IsPalindrome(number));  