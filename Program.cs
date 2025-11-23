using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhoneFinder
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть текст для пошуку номерів телефону:");
            string inputText = Console.ReadLine() ?? string.Empty;

            List<string> phones = FindPhones(inputText);

            if (phones.Count == 0)
            {
                Console.WriteLine("Номери телефону не знайдено.");
            }
            else
            {
                Console.WriteLine("Знайдені номери телефону:");
                foreach (string phone in phones)
                {
                    Console.WriteLine(phone);
                }
            }
        }

        private static List<string> FindPhones(string text)
        {
            const string phonePattern = @"\+3\(\d{3}\)-\d{3}-\d{4}";

            List<string> results = new List<string>();

            MatchCollection matches = Regex.Matches(text, phonePattern);

            foreach (Match match in matches)
            {
                results.Add(match.Value);
            }

            return results;
        }
    }
}