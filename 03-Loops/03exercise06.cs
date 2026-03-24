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

                while (!valid)
                {
                    Console.Write("Enter deposit amount: ");
                    string input = Console.ReadLine();

                    valid = double.TryParse(input, out deposit);

                    if (!valid)
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }

                balance += deposit;
                Console.WriteLine("New balance is: " + balance);
            }
            else if (inputOption == 3)
            {
                double withdraw = 0;
                valid = false;

                while (!valid)
                {
                    Console.Write("Enter withdraw amount: ");
                    string input = Console.ReadLine();

                    valid = double.TryParse(input, out withdraw);

                    if (!valid)
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }

                if (withdraw <= balance)
                {
                    balance -= withdraw;
                    Console.WriteLine("New balance is: " + balance);
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine();
        }
    }
}