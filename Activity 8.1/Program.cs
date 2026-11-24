using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable records = new Hashtable();
        int choice;

        do
        {
            Console.WriteLine("\n=== Record Keeping Program ===");
            Console.WriteLine("[1] Add Data");
            Console.WriteLine("[2] Delete Data");
            Console.WriteLine("[3] Display Data");
            Console.WriteLine("[4] End");
            Console.Write("Enter Choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input! Please enter a number from 1-4.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Key: ");
                    string addKey = Console.ReadLine();

                    if (records.ContainsKey(addKey))
                    {
                        Console.WriteLine("Error: Duplicate key! Key already exists.");
                    }
                    else
                    {
                        Console.Write("Enter Value: ");
                        string value = Console.ReadLine();

                        records.Add(addKey, value);
                        Console.WriteLine("Data added successfully.");
                    }
                    break;

                case 2:
                    Console.Write("Enter Key to Delete: ");
                    string deleteKey = Console.ReadLine();

                    if (records.ContainsKey(deleteKey))
                    {
                        records.Remove(deleteKey);
                        Console.WriteLine("Data deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Error: Key does not exist.");
                    }
                    break;

                case 3:
                    if (records.Count == 0)
                    {
                        Console.WriteLine("No records found.");
                    }
                    else
                    {
                        Console.WriteLine("\n--- Records ---");
                        Console.WriteLine("Key\tValue");

                        foreach (DictionaryEntry item in records)
                        {
                            Console.WriteLine($"{item.Key}\t{item.Value}");
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                    break;
            }

        } while (choice != 4);
    }
}
