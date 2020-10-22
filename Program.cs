using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Valadator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string phoneNumber = string.Empty;
            string email = string.Empty;
            string date = string.Empty;
            string html = string.Empty;
            string yesNo = string.Empty;
            do
            {
                Console.WriteLine("Please enter a name");          
                do
                {
                    name = Console.ReadLine();
                    if (NameValidator(name))
                    {
                        Console.WriteLine("thank you for a vailid input");
                        continue;
                    }
                    Console.WriteLine("Name format not valid, please enter a valid name");
                    
                }
                while (!NameValidator(name));
                Console.WriteLine("Please enter a  phone number");
                do
                {
                    phoneNumber = Console.ReadLine();
                    if (!PhoneNumberValidator(phoneNumber))
                    {
                        Console.WriteLine("thank you for a vailid input");
                        continue;
                    }
                    Console.WriteLine("Phone number format not valid, please enter a valid phone number");
                    
                }
                while (!PhoneNumberValidator(phoneNumber));
                Console.WriteLine("Please enter a  email");
                do
                {
                    email = Console.ReadLine();
                    if (!EmailValidator(email))
                    {
                        Console.WriteLine("thank you for a vailid input");
                        continue;
                    }
                    Console.WriteLine("Email format not valid, please enter a valid email");
                }
                while (!EmailValidator(email));
                Console.WriteLine("Please enter a  date");
                do
                {
                    date = Console.ReadLine();
                    if (!DateValidator(date))
                    {
                        Console.WriteLine("thank you for a vailid input");
                        continue;
                    }
                    Console.WriteLine("Date format not valid, please enter a valid date");
                }
                while (!DateValidator(date));
                Console.WriteLine("Please enter an html");
                do
                {
                    html = Console.ReadLine();
                    if (!HtmlValidator(html))
                    {
                        Console.WriteLine("thank you for a vailid input");
                        continue;
                    }
                    Console.WriteLine("HTML format not valid, please enter a valid HTML");
                }
                while (!HtmlValidator(html));

                Console.WriteLine("The info you have entered is:");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Phone number: {phoneNumber}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"HTML: {html}");
                Console.WriteLine("\n");
                Console.WriteLine($"Is this info correct?");
                Console.WriteLine($"Plese enter yes or no");
                yesNo = Console.ReadLine();
            }  
            while (!YesNoValidator(yesNo));
            Console.WriteLine("thank you for submitting your data using my validation program!");
        }
        private static bool NameValidator(string name)
        {
            Regex namePattern = new Regex(@"^[A-Z]{1}[a-z]{1,29}");

            return namePattern.IsMatch(name); 
        }

        private static bool PhoneNumberValidator(string phoneNumber)
        {
            Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

            return (phoneNumberPattern.IsMatch(phoneNumber)); 
        }
        
        private static bool EmailValidator(string email)
        {
            Regex emailPattern = new Regex(@"^[A-z,0-9]{5,30}@[A-z,0-9]{5,10}.com");

            return (emailPattern.IsMatch(email));
        }

        private static bool DateValidator(string date)
        {
            Regex datePattern = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");

            return (datePattern.IsMatch(date));
        }

        private static bool HtmlValidator(string html)
       {
            Regex htmlTagPattern = new Regex(@"^<[a-z]+>.+?<\/[a-z]+>$");
            return (htmlTagPattern.IsMatch(html));       
       }

        private static Boolean YesNoValidator(string yesNo)
        {
            Regex yesNoPattern = new Regex(@"^((Y|y)|(ES|es))");
            if (yesNoPattern.IsMatch(yesNo))
            {
                return true;
            }
            return false;
        } 
    }
}
