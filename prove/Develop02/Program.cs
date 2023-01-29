using System;

class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>() {
        "What is one good thing that happened today?",
        "Did you make someone happy today?",
        "Is there something you wish you could have done differently today?",
        "Was there an emotion that was particullarly strong today? if so, why?",
        "What do you hope for tomorrow?"
    };
    public void NewEntry()
    {
        Random rnd = new Random();
        int promptIndex = rnd.Next(prompts.Count);
        string selectedPrompt = prompts[promptIndex];
        Console.WriteLine("New prompt: " + selectedPrompt);
        string response = Console.ReadLine();
        Entry newEntry = new Entry(selectedPrompt, response, DateTime.Now);
        entries.Add(newEntry);
    }
    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (Entry entry in entries)
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine("***************************************************************");
        }
    }
    public void SaveJournal()
    {
        Console.WriteLine("What would you like to name this journal entry for today?:");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        foreach (Entry entry in entries)
        {
            outputFile.WriteLine("Prompt: " + entry.Prompt);
            outputFile.WriteLine("Entry: " + entry.Response);
            outputFile.WriteLine("Date: " + entry.Date);
            outputFile.WriteLine();
        }
    }
    public void LoadJournal()
    {
        Console.WriteLine("Enter a filename to load the journal from:");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
           string[] parts = line.Split(",");
            string firstName = parts[0];
            string lastName = parts[1]; 
        }
    }
    public void ShowMenu()
    {
        string input = "";
        while (input != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine();
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine();

            Console.WriteLine("Please select an option:");
            input = Console.ReadLine();

            if (input == "1")
            {
                NewEntry();
            }
            else if (input == "2")
            {
                DisplayJournal();
            }
            else if (input == "3")
            {
                SaveJournal();
            }
            else if (input == "4")
            {
                LoadJournal();
            }
            else if (input == "5")
            {
                Console.WriteLine ("Goodbye, and have a lovely day.");
            }
            else
            {
                Console.WriteLine("I dont think thats an option, Please try again.");
            }
        }
    }
}
class Entry
{
    public Entry(string prompt, string response, DateTime date)
{
    this.Prompt = prompt;
    this.Response = response;
    this.Date = date.ToString();
}
    public string Prompt;
    public string Response;
    public string Date;
}
class Program
{
public static void Main()
{
    Console.WriteLine("Hello, welcome to your journal, what can I do for you?");
    Console.WriteLine();
    Journal journal = new Journal();
    journal.ShowMenu();
}
}