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

            Console.Write("Choose an option: "); 
            int inputOption = int.Parse(Console.ReadLine());

            if (inputOption == 0)
            {
                break;
            }
            else if (inputOption == 1)
            {
                Console.WriteLine("Your balance is: " + balance);
            }
            else if (inputOption == 2)
            {
                Console.WriteLine("Enter deposit amount: ");
                double deposit = double.Parse(Console.ReadLine());

                balance += deposit;
                Console.WriteLine("New balance is: " + balance);
            }
            else if (inputOption == 3)
            {
                Console.WriteLine("Enter Withdraw amount: ");
                double withdraw = double.Parse(Console.ReadLine());

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