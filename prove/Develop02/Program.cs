using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {   
        int intSelection;
        Journal journal = new Journal();

        do
        {   
            Console.WriteLine("Welcome to the Journal app!"); 
            Console.WriteLine("Please select an option from the menu: "); 
            Console.WriteLine("\n-1. New entry"); 
            Console.WriteLine("-2. View entries"); 
            Console.WriteLine("-3. Load file"); 
            Console.WriteLine("-4. Save file"); 
            Console.WriteLine("-5. Exit"); 
            Console.Write("-->");
            
            string selection = Console.ReadLine();
            intSelection = int.Parse(selection);

            //option 1 - new entry
            if(intSelection == 1)
            {
                Entry entry = new Entry();
                entry.NewEntry();
                journal.AddEntry(entry);
                Console.Write("Hit enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }

            //option 2 - view entries
            else if(intSelection == 2)
            {
                journal.DisplayAll();
                Console.Write("\nHit enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }

            //Option 3 - load file
            else if (intSelection == 3)
            {
                journal.LoadFile();
                Console.Write("Hit enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }
            
            //Option 4 - save file
            else if (intSelection == 4)
            {
                journal.SaveFile();
                Console.Write("Hit enter to continue...");
                Console.ReadLine();
                Console.Clear();
            }

            else if (intSelection == 5)
            {
                break;
            }

            //if option is not available
            else
            {
                Console.WriteLine("Please enter a valid option!");
                Console.Write("Hit enter to continue...");
                Console.ReadLine();
                Console.Clear();

            }

        }while(intSelection != 5);

    }
}