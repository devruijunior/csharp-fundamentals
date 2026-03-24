using System;

class Program
{
    static void Main()
    {
        int balance = 1000;

        while (true)
        {
            Console.WriteLine("—— Simple Menu System ——"); 
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
                Console.WriteLine("Deposit selected");
            }
            else if (inputOption == 3)
            {
                Console.WriteLine("Withdraw selected");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }

            Console.WriteLine(); 
        }
    }
}