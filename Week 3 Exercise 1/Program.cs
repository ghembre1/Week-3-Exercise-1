using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Exercise_1
{
    internal class Program
    {
        // These are the conversion rates
        private static readonly double USD_TO_EUR = 0.85;
        private static readonly double USD_TO_JPY = 110.25;
        private static readonly double EUR_TO_USD = 1.18;
        private static readonly double EUR_TO_JPY = 129.75;
        private static readonly double JPY_TO_USD = 0.0091;
        private static readonly double JPY_TO_EUR = 0.0077;
        static void Main(string[] args)
        {
            // Prints line for currency converter
            Console.WriteLine("Currency Converter");
            // Prompts user to enter their currency
            Console.Write("Enter your currency (USD, EUR, JPY): ");
            // Converts users input to uppercase
            string fromCurrency = Console.ReadLine().ToUpper();
            // Prompts users to enter what currency they want to convert to
            Console.Write("Enter target currency (USD, EUR, JPY): ");
            // Converts users input to uppercase
            string toCurrency = Console.ReadLine().ToUpper();
            // prompts user to enter the amount they want to convert
            Console.Write("Enter amount to convert: ");
            // If they amount they put in is wrong they get prompted saying invalid amount
            if (!double.TryParse(Console.ReadLine(), out double amount))
            {
                Console.WriteLine("Invalid amount.");
                return;
            }
            // sets result as a variable
            double result = Convert(fromCurrency, toCurrency, amount);
            // if results is greater than 0 it runs the function
            if (result >= 0)
            {
                Console.WriteLine($"{amount} {fromCurrency} = {result} {toCurrency}"); // converts from currency to the to currency
            }
            else
            {
                Console.WriteLine("Conversion failed."); // if the amount is less than 0 it prompts failed
            }
        }

        static double Convert(string fromCurrency, string toCurrency, double amount)
        {
            if (fromCurrency == toCurrency) // takes the from currency and compares it to the tocurrency
                return amount; 

            // This is the USD conversion
            if (fromCurrency == "USD")
            {
                if (toCurrency == "EUR") return amount * USD_TO_EUR;
                if (toCurrency == "JPY") return amount * USD_TO_JPY;
            }
            // This is the EUR conversion
            if (fromCurrency == "EUR")
            {
                if (toCurrency == "USD") return amount * EUR_TO_USD;
                if (toCurrency == "JPY") return amount * EUR_TO_JPY;
            }
            // This is the JPY conversion
            if (fromCurrency == "JPY")
            {
                if (toCurrency == "USD") return amount * JPY_TO_USD;
                if (toCurrency == "EUR") return amount * JPY_TO_EUR;
            }
            // if what the user inputed is wrong it will prompt unsupported currency
            Console.WriteLine("Unsupported currency.");
            return -1;
        }
    }
}
