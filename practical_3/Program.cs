using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expenseNames = new string[100];
            double[] expenseAmounts = new double[100];
            int expenseCount = 0;
            double total = 0;
            bool isRunning = true;

            Console.WriteLine("Welcome to Expense Tracking Module");

            while (isRunning)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. End Trip");
                Console.Write("Enter your choice (1 or 2): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        try
                        {
                            Console.Write("Enter name of expense: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter how much money: ");
                            string amountInput = Console.ReadLine();
                            double amount = Convert.ToDouble(amountInput);

                            expenseNames[expenseCount] = name;
                            expenseAmounts[expenseCount] = amount;
                            expenseCount++; 

                            total = total + amount;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Please enter a valid number for the amount.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An unexpected error occurred: " + ex.Message);
                        }
                        break;

                    case "2":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                        break;
                }
            }

            Console.WriteLine("\n--- Trip Expenses ---");
            for (int i = 0; i < expenseCount; i++)
            {
                Console.WriteLine("Expense: " + expenseNames[i] + " | Amount: " + expenseAmounts[i]);
            }
            Console.WriteLine("Total Amount Spent: " + total);

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}
