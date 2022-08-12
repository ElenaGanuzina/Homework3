// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int number)
{
    if (number < 10000 && number > 99999)
        Console.WriteLine("Введите пятизначное число");
    else
        {
            if (number / 10000 == number % 10 && (number / 1000) % 10 == (number % 100) / 10)
                Console.WriteLine($"{number} -> да");
            else
                Console.WriteLine($"{number} -> нет");
        }
}

Palindrome(43625);
Palindrome(57275);
Palindrome(34);
Palindrome(1234321); 

