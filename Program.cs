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
                }
                while (!NameValidator(name));

                Console.WriteLine("Please enter a  phone number");
                do
                {
                    phoneNumber = Console.ReadLine();
                }
                while (!PhoneNumberValidator(phoneNumber));

                Console.WriteLine("Please enter a  email");
                do
                {
                    email = Console.ReadLine();
                }
                while (!EmailValidator(email));

                Console.WriteLine("Please enter a  date");
                do
                {
                    date = Console.ReadLine();
                }
                while (!DateValidator(date));
                Console.WriteLine("Please enter an html");
                do
                {
                    html = Console.ReadLine();
                }
                while (!HtmlValidator(html));

                Console.WriteLine("The info you habe entered is:");
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

            if (namePattern.IsMatch(name)) 
            {
                return true;
            }
            Console.WriteLine("Name format not valid, please enter a valid name");
            return false;
        }

        private static bool PhoneNumberValidator(string phoneNumber)
        {
            Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

            if (phoneNumberPattern.IsMatch(phoneNumber)) 
            {
                return true;
            }
            Console.WriteLine("Phone number format not valid, please enter a valid phone number");
            return false;
        }
      
    private static bool EmailValidator(string email)
        {
            Regex emailPattern = new Regex(@"^[A-z,0-9]{5,30}@[A-z,0-9]{5,10}.com");

            if (emailPattern.IsMatch(email))
            {
                return true;
            }
            Console.WriteLine("Email format not valid, please enter a valid email");
            return false;
        }

        private static bool DateValidator(string date)
        {
            Regex datePattern = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");

            if (datePattern.IsMatch(date))
            {
                return true;

            }
            Console.WriteLine("Date format not valid, please enter a valid date");
            return false;
            
        }
       private static bool HtmlValidator(string html)
       {
            Regex htmlTagPattern = new Regex(@"^<[a-z]+>.+?<\/[a-z]+>$");
            if (htmlTagPattern.IsMatch(html))
            {
                return true;
            }
            Console.WriteLine("HTML format not valid, please enter a valid HTML");
            return false;
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
