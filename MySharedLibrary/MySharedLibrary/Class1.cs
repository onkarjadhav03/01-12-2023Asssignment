using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySharedLibrary
{
    public class Class1
    {
        public static bool IsNumber(string input)
        {
            return int.TryParse(input, out _);
        }

        public static void LogMessage(string message)
        {
            Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
        }

        public static string Encrypt(string input)
        {
            // Implement encryption logic here
            return $"Encrypted: {input}";
        }
    }
}
