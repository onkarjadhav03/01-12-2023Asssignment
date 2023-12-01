using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "123";

            // Example usage of utility methods
            bool isNumber = MySharedLibrary.Class1.IsNumber(userInput);
            MySharedLibrary.Class1.LogMessage($"User input: {userInput}, IsNumber: {isNumber}");
            string encryptedText = MySharedLibrary.Class1.Encrypt("SensitiveData");
            Console.WriteLine(encryptedText);
        }
    }
}
