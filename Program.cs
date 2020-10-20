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
            Console.WriteLine("Please enter a name");
            do
            {
                name = Console.ReadLine();
            } 
            while (!NameValadator(name));

            Console.WriteLine("Please enter a  phone number");
            do
            {
               phoneNumber = Console.ReadLine();
            }
            while (!PhoneNumberValadator(phoneNumber));

            Console.WriteLine("Please enter a  email");
            do
            {
                email = Console.ReadLine();
            } 
            while (!EmailValadator(email));

            Console.WriteLine("Please enter a  date");
            do
            {
                date = Console.ReadLine();
            } 
            while (!DateValadator(date));
            do
            {
                html = Console.ReadLine();
            }
            while (!HtmlValadator(html));

            Console.WriteLine("The info you habe entered is:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Phone number: {phoneNumber}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"HTML: {html}");
        }
        private static bool NameValadator(string name)
        {
            Regex namePattern = new Regex(@"^[A-Z]{1}[a-z]{1,29}");

            if (namePattern.IsMatch(name)) 
            {
                return true;
            }
            Console.WriteLine("Name format not valid, please enter a valid name");
            return false;
        }

        private static bool PhoneNumberValadator(string phoneNumber)
        {
            Regex phoneNumberPattern = new Regex(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$");

            if (phoneNumberPattern.IsMatch(phoneNumber)) 
            {
                return true;
            }
            Console.WriteLine("Phone number format not valid, please enter a valid phone number");
            return false;
        }
      
    private static bool EmailValadator(string email)
        {
            Regex emailPattern = new Regex(@"^[A-z,0-9]{5,30}@[A-z,0-9]{5,10}.com");

            if (emailPattern.IsMatch(email))
            {
                return true;
            }
            Console.WriteLine("Email format not valid, please enter a valid email");
            return false;
        }

        private static bool DateValadator(string date)
        {
            Regex datePattern = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}");

            if (datePattern.IsMatch(date))
            {
                return true;

            }
            Console.WriteLine("Date format not valid, please enter a valid date");
            return false;
            
        }
       private static bool HtmlValadator(string html)
       {
            Regex htmlTagPattern = new Regex(@"^<[a-z]+>.+?<\/[a-z]+>$");
            if (htmlTagPattern.IsMatch(html))
            {
                return true;
            }
            Console.WriteLine("HTML format not valid, please enter a valid HTML");
            return false;
       }
    }
}
