using System;
using System.Text;
using Lab6CSharp;


static class Program
{
    static void Task1()
    {
         var ukraine = new Republic("Україна", 41000000, 603628, "Володимир Зеленський");
        ukraine.Show();

        var uk = new Monarchy("Великобританія", 67000000, 243610, "Королева Єлизавета II");
        uk.Show();

        var saudiArabia = new Kingdom("Саудівська Аравія", 34000000, 2149690, "Король Салман", 5000);
        saudiArabia.Show();

        var usa = new State("США", 331000000, 9833517, "Федеральна держава", "Джо Байден");
        usa.Show();

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void Task2()
    {
        // Creating a catalog with n publications
        IPublication[] catalog = new IPublication[]
        {
            new Book("Thrones for Gods", "Martin", 1996, "Bantam"),
            new Article("The Art of Writing", "Petrov", "Beauty of Language", 3, 2020),
            new ElectronicResource("Universe in a Room", "Sydorenko", "http://example.com", "Annotation for the electronic resource")
        };

        // Displaying full information from the catalog
        Console.WriteLine("Full information from the catalog:");
        foreach (var item in catalog)
        {
            item.DisplayInfo();
            Console.WriteLine();
        }

        // Searching for publications by author's last name
        string searchAuthor = "Martin";
        Console.WriteLine($"\nSearching for publications by author {searchAuthor}:");
        foreach (var item in catalog)
        {
            if (item.IsAuthor(searchAuthor))
            {
                item.DisplayInfo();
                Console.WriteLine();
            }
        }
    }

    static void Task3()
    {
        // Example of using the Rectangle class with foreach
        Rectangle rect = new Rectangle(5, 10, 2);

        Console.WriteLine("Rectangle sides and color index using foreach:");
        foreach (var value in rect)
        {
            Console.WriteLine(value);
        }
    }

    static void ShowMenu()
    {
        string[] menuStrings =
        {
            "1. Task 1!",
            "2. Task 2!",
            "3. Task 3!"
        };
        int currentOption = 0;
        ConsoleKeyInfo keyInfo;
        int choice = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Lab 6 CSharp!");
            PrintMenu(menuStrings, currentOption);

            keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.DownArrow)
            {
                currentOption = currentOption + 1 <= menuStrings.Length - 1 ? currentOption + 1 : 0;
            }
            else if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.UpArrow)
            {
                currentOption = currentOption - 1 >= 0 ? currentOption - 1 : menuStrings.Length - 1;
            }
            else if (keyInfo.Key == ConsoleKey.Enter)
            {
                choice = currentOption;
                break;
            }
        }
        switch (choice)
        {
            case 0:
                Console.WriteLine("Task1!");
                Task1();
                break;
            case 1:
                Console.WriteLine("Task2!");
                Task2();
                break;
            case 2:
                Console.WriteLine("Task3!");
                Task3();
                break;
            default:
                break;
        }
    }

    static void PrintMenu(string[] menuStrings, int chosenString)
    {
        for (int i = 0; i < menuStrings.Length; i++)
        {
            if (i == chosenString)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine(menuStrings[i]);
            if (i == chosenString)
            {
                Console.ResetColor();
            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        while (true)
        {
            Console.Clear();
            ShowMenu();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
