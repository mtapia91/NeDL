using System;

namespace filesproject
{
  class Program
  {
    static void Main(string[] args)
    {
        string writeText = "Hello NeDL!";  // Create a text string
        File.WriteAllText("HelloNeDL.txt", writeText);  // Create a file and write the content of writeText to it

        string readText = File.ReadAllText("HelloNeDL.txt");  // Read the contents of the file
        Console.WriteLine(readText);  // Output the content    
    }
  }
}