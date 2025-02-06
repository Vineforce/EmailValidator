using Vineforce;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the email address to check if it's disposable:");
            string userEmail = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userEmail))
            {
                // Call the method to check if the email is disposable
                EmailValidator emailValidator = new EmailValidator();
                bool isDisposable = emailValidator.IsDisposableEmail(userEmail);
                // Output the result
                if (isDisposable)
                {
                    Console.WriteLine($"The email '{userEmail}' is disposable.");
                }
                else
                {
                    Console.WriteLine($"The email '{userEmail}' is not disposable.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid email address.");
            }
        }
    }
}