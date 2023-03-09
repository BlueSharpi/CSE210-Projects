using System;

class Program
{
    static void Main(string[] args)
    {
        bool on = true;
        bool loaded = false;
        bool saved = true;
        int input;
        Console.WriteLine($"{DateTime.Now.ToString("MM.dd.yyyy")}");
        Console.WriteLine("Welcome to the Journal Program!");
        
        Journal j = new Journal();

        while (on == true) {
            Console.Clear();
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display Entries\n3. Save Journal\n4. Load Journal\n5. Exit");
            Console.Write("What would you like to do? ");
            input = int.Parse(Console.ReadLine());
            
            if (input == 1) {
                if (loaded == false) {
                    Console.WriteLine("Load a journal first? ( y or n ) ");
                    string load = Console.ReadLine();
                    if (load == "y") {j.LoadFromCSV(); loaded = true;}
                }
                j.CreateJournalEntry();
                loaded = true;
                saved = false;
            }
            if (input == 2) {
                j.DisplayJournalEntries();
            }
            if (input == 3) {
                j.SaveToCSV();
                saved = true;
            }
            if (input == 4) {
                if (saved == false) {
                    Console.Write("Save Current Journal? ( y or n ) ");
                    string save = Console.ReadLine();
                    if (save == "y") {j.SaveToCSV(); saved = true;}
                }
                j._entries.Clear();
                j.LoadFromCSV();
                loaded = true;
            }
            if (input == 5) {
                if (saved == false) {
                    Console.Write("Save before quitting? ( y or n ) ");
                    string save = Console.ReadLine();
                    if(save == "y") {j.SaveToCSV();}
                }
                Console.WriteLine("\nThank you. Goodbye! :)\n");
                on = false;
            }
        }


    }
}