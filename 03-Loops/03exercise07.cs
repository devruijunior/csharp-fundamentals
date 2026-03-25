using System;

class Program
{
    static void Main()
    {
        double balance = 1000;

        while (true)
        {
            Console.WriteLine("—— Simple bank Menu ——"); 
            Console.WriteLine("----------------------"); 
            Console.WriteLine();

            Console.WriteLine("1 - Check Balance");
            Console.WriteLine("2 - Deposit"); 
            Console.WriteLine("3 - Withdraw");
            Console.WriteLine("0 - Exit");
            Console.WriteLine(); 

            int inputOption = 0;
            bool valid = false;

            // MENU INPUT VALIDATION
            while (!valid)
            {
                Console.Write("Choose an option: ");
                string input = Console.ReadLine();

                valid = int.TryParse(input, out inputOption);

                if (!valid)
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            if (inputOption == 0)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else if (inputOption == 1)
            {
                Console.WriteLine("Your balance is: " + balance);
            }
            else if (inputOption == 2)
            {
                double deposit = 0;
                valid = false;

                // DEPOSIT VALIDATION
                while (!valid)
                {
                    Console.Write("Enter deposit amount: ");
                    string input = Console.ReadLine();

                    if (!double.TryParse(input, out deposit))
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                    else if (deposit <= 0)
                    {
                        Console.WriteLine("Amount must be greater than zero.");
                    }
                    else
                    {
                        valid = true;
                    }
                }

                balance += deposit;
                Console.WriteLine("New balance is: " + balance);
            }
            else if (inputOption == 3)
            {
                double withdraw = 0;
                valid = false;

                // WITHDRAW VALIDATION
                while (!valid)
                {
                    Console.Write("Enter withdraw amount: ");
                    string input = Console.ReadLine();

                    if (!double.TryParse(input, out withdraw))
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                    else if (withdraw <= 0)
                    {
                        Console.WriteLine("Amount must be greater than zero.");
                    }
                    else if (withdraw > balance)
                    {
                        Console.WriteLine("Insufficient funds.");
                    }
                    else
                    {
                        valid = true;
                    }
                }

                balance -= withdraw;
                Console.WriteLine("New balance is: " + balance);
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine();
        }
    }
}