using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To New Bank");
            Console.WriteLine("--------------------");
            Console.Write("Username: ");
            string username = null, password = null;
            username = Console.ReadLine();
            if(username != null)
            {
                Console.Write("Password: ");
                password = Console.ReadLine();
            }
            if (username == "hello" && password == "password")
            {
                int mainMenuChoice = -1;
                do
                {
                    Console.WriteLine("**** Main Menu****");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("1. Customers");
                    Console.WriteLine("2. Accounts");
                    Console.WriteLine("3. Funds Transfer");
                    Console.WriteLine("4. Funds transfer statement");
                    Console.WriteLine("5. Account statement");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter the main menu choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    switch (mainMenuChoice)
                    {
                        case 1:
                            //TO DO Customers menu
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                    }
                } while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Please enter valid credentials");
            }

            Console.WriteLine("Thanks for banking in New bank");
        }
    }
}
