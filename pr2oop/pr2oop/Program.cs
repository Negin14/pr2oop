using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== ЗАВДАННЯ 1: Перевірка логіна ===");
        string inputLogin;

        while (true)
        {
            Console.Write("Введіть логін для перевірки: ");
            inputLogin = Console.ReadLine();

            if (ValidateLogin(inputLogin))
            {
                Console.WriteLine("Логін коректний!\n");
                break;
            }
            else
            {
                Console.WriteLine("Помилка: логін має бути від 2 до 10 символів, містити ТІЛЬКИ англійські літери і цифри, і починатися з літери. Спробуйте ще раз.\n");
            }
        }

        Console.WriteLine("=== ЗАВДАННЯ 2: Фільтр виразів із урахуванням форм ===");
        Console.Write("Введіть текст для фільтрації: ");
        string inputText = Console.ReadLine();

        string filteredText = FilterText(inputText);
        Console.WriteLine("Результат: " + filteredText);
    }

    static bool ValidateLogin(string login)
    {
        string pattern = @"^[a-zA-Z][a-zA-Z0-9]{1,9}$";
        return Regex.IsMatch(login, pattern);
    }

    static string FilterText(string input)
    {
        string pattern = @"\bспам[а-яА-Я]*\b";
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
        return regex.Replace(input, "[заблоковано]");
    }
}