using System;
using static System.Console;

namespace Single_Responsibility_Principle
{
     // just stores a couple of journal entries and ways of
  // working with them
  public class Journal
  {
    private readonly List<string> entries = new List<string>();

 
 
    private static int count = 0;

    public int AddAnEntry(string text)
    {
      entries.Add($"{++count}: {text}");
       
      return count; // memento pattern!
    }

    public void RemoveAnEntry(int index)
    {
      entries.RemoveAt(index);
    }

    public override string ToString()
    {
      return string.Join(Environment.NewLine, entries);
    }

    // breaks single responsibility principle
    public void Save(string filename, bool overwrite = false)
    {
      File.WriteAllText(filename, ToString());
    }

   // performs loading of journal objects
    public void Load(string filename)
    {
      
    }

  }

  // handles the responsibility of persisting journal objects
  public class Persistence
  {
    public void SaveToFile(Journal journal, string filename, bool overwrite = false)
    {
      if (overwrite || !File.Exists(filename))
        File.WriteAllText(filename, journal.ToString());
    }
  }

    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Demo of Single Responsibility Principle");

            var journal = new Journal();
            journal.AddAnEntry("I cried today.");
            journal.AddAnEntry("I ate a bug.");
            WriteLine(journal);

            var persistence = new Persistence();
            var filename = @"c:\\Temp\\myjournal.txt";
            persistence.SaveToFile(journal, filename);
            Process.Start(filename);
        }
    }
}
