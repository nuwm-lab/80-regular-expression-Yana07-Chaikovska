using System;

namespace RegexIpFinder
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть текст для пошуку IP-адрес:");
            string inputText = Console.ReadLine();

            IpFinder finder = new IpFinder();
            var ipAddresses = finder.FindIpAddresses(inputText);

            if (ipAddresses.Count == 0)
            {
                Console.WriteLine("IP-адрес не знайдено.");
            }
            else
            {
                Console.WriteLine("Знайдені IP-адреси:");
                foreach (var ip in ipAddresses)
                {
                    Console.WriteLine(ip);
                }
            }
        }
    }
}
