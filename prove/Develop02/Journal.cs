using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();

        Console.WriteLine("\n\nWhat is the date? ");
        entry._date = Console.ReadLine();

        Console.WriteLine("What is your current mood? ");
        entry._mood = Console.ReadLine();

        entry._prompt = entry.DisplayPrompt();
        entry._response = Console.ReadLine();

        Console.WriteLine("\n");

        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveFile()
    {
        Console.WriteLine("Enter the name for your Journal (include \".txt\" at the end of the file name): ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.GetForStorage());
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("Enter the name for your Journal (include \".txt\" at the end of the file name): ");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            Entry entry = new Entry();

            string[] parts = line.Split(",");

            entry._date = parts[0];
            entry._mood = parts[1];
            entry._prompt = parts[2];
            entry._response = parts[3];

            _entries.Add(entry);
        }
    }
}