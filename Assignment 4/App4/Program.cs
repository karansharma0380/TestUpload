using System;
class program
{
    public static void Main()
    {
        int amount = 10000, deposit, withdraw;
        int choice, pin = 0, x = 0;
        Console.WriteLine("\n\tWelcome to ICIC ATM Services\t\n");
        Console.WriteLine("Enter your 4 digit pin:");
        pin = int.Parse(Console.ReadLine());
        if (pin == 1234)
        {
            while (true)
            {
                Console.WriteLine("\n\t********  Dashboard  ********\n\n");
                Console.WriteLine("\t1. Current balance\n");
                Console.WriteLine("\t2. Withdraw\n");
                Console.WriteLine("\t3. Deposit\n");
                Console.WriteLine("\t4. Cancel\n");
                Console.WriteLine("====================\n\n");
                Console.WriteLine("enter you choice\n");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n your current balance is RS: {0}", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n enter your withdraw amount:");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n please enter the amount in above 100");
                        }
                        else if (withdraw > (amount - 1000))
                        {
                            Console.WriteLine("\n sorry! insufficent balance.......................");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n please collect your cash");
                            Console.WriteLine("\n current balance is RS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n enter the deposit amount");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("your amount has been deposited successfully......................");
                        Console.WriteLine("your total balance is RS {0}", amount);
                        break;
                    case 4:
                     
                        Console.WriteLine("\n\n Thanks for using ATM Service.");
                        return;
                    
                       
                }
            }
        }
        else 
        {
            Console.WriteLine("\t\n Wrong Pin.....");
        }
        
        Console.WriteLine("\n\n Thanks for using ATM Services.");
    }
}
