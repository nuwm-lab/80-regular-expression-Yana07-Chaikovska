using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Приклад: дзвоніть за номером +3(123)-456-7890 або +3(987)-654-3210. Інші формати ігноруємо.";

        string pattern = @"\+3\(\d{3}\)-\d{3}-\d{4}";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Знайдені номери телефонів:");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
