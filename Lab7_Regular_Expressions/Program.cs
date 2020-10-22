using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace Lab7_Regular_Expressions
{

    class Program
    {
        static void isName()
        {
            Console.Write("Please enter a name: ");
            string userInput = Console.ReadLine();

            Regex regexPattern = new Regex(@"^[A-Z]\w{1,29}$");

            if (regexPattern.IsMatch(userInput))
            {
                Console.WriteLine($"{userInput} qualifies as a name.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a valid name.");
            }
        }

        static void isEmail()
        {
            Console.Write("Please enter an Email (ex. something@gmail.com): ");
            string userInput = Console.ReadLine();

            Regex regexPattern = new Regex(@"^\w{5,30}@\w{5,10}\.\w{2,3}$");

            if (regexPattern.IsMatch(userInput))
            {
                Console.WriteLine($"{userInput} qualifies as an Email.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a valid Email.");
            }
        }

        static bool isPhoneNumber(string phonenumber)
        {
            Console.Write("Please enter a phone number (ex. (555) 555-5555 or 555-555-5555): ");
            string userInput = Console.ReadLine();

            Regex regexPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

            if (regexPattern.IsMatch(userInput))
            {
                Console.WriteLine($"{userInput} qualifies as a phone number.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a valid phone number.");
            }
        }

        static bool isDate(string date)
        {
            Console.Write("Please enter a date (mm/dd/yyyy): ");
            string userInput = Console.ReadLine();

            Regex regexPattern = new Regex(@"");

            if (regexPattern.IsMatch(userInput))
            {
                Console.WriteLine($"{userInput} qualifies as date.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a valid date.");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("So what shall we validate today?\n1. Name\n2. Email\n3. Phone Number\n4. Date\n");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case: 1 
                    isName(name);
                    break;

                case: 2
                    isEmail(email);
                    break;

                case: 3
                    isPhoneNumber(phonenumber);
                    break;

                case: 4
                    isDate(date);
                    break;

                default:
                    Console.WriteLine("Not a Valid Entry, Try Again");
                    break;
            }
        }
    }
}
Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

Console.WriteLine("please insert a valid phone number");
string phoneNumber = Console.ReadLine();

string badPhoneNumber = "lol, I'm not a number ;)";

if (phoneNumberPattern.IsMatch(phoneNumber))
{
    Console.WriteLine("This is a valid number");
}

if (!phoneNumberPattern.IsMatch(badPhoneNumber))
{
    Console.WriteLine("this is a bad phone number :(");
}