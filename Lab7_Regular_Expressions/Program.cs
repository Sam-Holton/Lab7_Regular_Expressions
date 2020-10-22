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

        static void isPhoneNumber()
        {
            Console.Write("Please enter a phone number (ex. (555) 555-5555 or 555-555-5555): ");
            string userInput = Console.ReadLine();

            Regex regexPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$"); // credit to James Jackson for doing in class

            if (regexPattern.IsMatch(userInput))
            {
                Console.WriteLine($"{userInput} qualifies as a phone number.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a valid phone number.");
            }
        }
        
        static void isDate()
        {
            Console.Write("Please enter a date (dd/mm/yyyy): ");
            string userInput = Console.ReadLine();

            // Credit to Macs Dickinson of regexr.com Community Patterns cause my head was about to explode.
            Regex regexPattern = new Regex(@"^(((0[1-9]|[12][0-9]|3[01])[- /.](0[13578]|1[02])|(0[1-9]|[12][0-9]|30)[- /.](0[469]|11)|(0[1-9]|1\d|2[0-8])[- /.]02)[- /.]\d{4}|29[- /.]02[- /.](\d{2}(0[48]|[2468][048]|[13579][26])|([02468][048]|[1359][26])00))$");

            if (regexPattern.IsMatch(userInput))
            {
                Console.WriteLine($"{userInput} qualifies as a date.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a valid date.");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("1. Name\n2. Email\n3. Phone Number\n4. Date\nSo what shall we validate today? ");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1: 
                    isName();
                    break;

                case 2:
                    isEmail();
                    break;

                case 3:
                    isPhoneNumber();
                    break;

                case 4:
                    isDate();
                    break;

                default:
                    Console.WriteLine("Not a Valid Entry, Try Again");
                    break;
            }
        }
    }
}