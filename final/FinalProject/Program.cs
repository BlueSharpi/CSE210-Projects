using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Menu m = new Menu();
        User u = new User();
        bool on = true;

        while (on)
        {
            // Login Menu
            Console.Clear();
            m.DisplayMenu(1);
            int input = m.IntPrompt("");
            bool loggedIn = false;
            string username;
            string password;
            switch (input)
            {
                case 1: // Login with an existing username and password
                    break;

                case 2: // Create a new username and password
                    Console.Clear();
                    Console.Write("Create Username: ");
                    username = Console.ReadLine();
                    Console.Write("Create Password: ");
                    password = Console.ReadLine();
                    u = new User(username, password);
                    loggedIn = true;
                    break;

                case 3: // Enter as a Guest (fastest way)
                    loggedIn = true;
                    break;

                case 4: // Exit the Program
                    on = false;
                    Console.Clear();
                    break;
            }

            // Main Menu
            while (loggedIn)
            {
                Console.Clear();
                Console.WriteLine(u.GetUsername());
                m.DisplayMenu(2);
                input = m.IntPrompt("");
                switch (input)
                {
                    case 1: // Transactions
                        break;
                    case 2: // Budget
                        break;
                    case 3: // Save
                        break;
                    case 4: // Log Out
                        u = new User();
                        loggedIn = false;
                        Console.Clear();
                        Console.WriteLine("\nLogging out... ");
                        Thread.Sleep(2000);
                        break;
                }
            }

        }
    
    }
}