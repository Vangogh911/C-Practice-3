// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrome (int num)
{
    if (9 < num || num < -9)
    {
        int savedNum = num;
        List<int> digits = new List<int>(); 
        while (num > 10)
        {
            digits.Add(num%10);
            num = num/10;
        }
        digits.Add(num);
        
        List<int> reverseDigits = new List<int>(digits);
        digits.Reverse();

        if (digits.SequenceEqual(reverseDigits)) Console.WriteLine($"Число {savedNum} является палиндромом");
        else Console.WriteLine($"Число {savedNum} не является палиндромом");
    }
    else Console.WriteLine($"Число {num} содержит недостаточно цифр");
}

Palindrome(14212);
Palindrome(12821);
Palindrome(23432);
Palindrome(2);
Palindrome(-23432);
