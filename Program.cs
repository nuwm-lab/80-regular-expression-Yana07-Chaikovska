using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexIpFinder
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть текст для пошуку IP-адрес:");
            string inputText = Console.ReadLine() ?? string.Empty;

            List<string> ipAddresses = FindIpAddresses(inputText);

            if (ipAddresses.Count == 0)
            {
                Console.WriteLine("IP-адрес не знайдено.");
            }
            else
            {
                Console.WriteLine("Знайдені IP-адреси:");
                foreach (string ip in ipAddresses)
                {
                    Console.WriteLine(ip);
                }
            }
        }

        private static List<string> FindIpAddresses(string text)
        {
            const string ipPattern =
                @"\b((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}"
                + @"(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\b";

            List<string> results = new List<string>();

            MatchCollection matches = Regex.Matches(text, ipPattern);

            foreach (Match match in matches)
            {
                results.Add(match.Value);
            }

            return results;
        }
    }
}
