using System;

namespace Music
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            string[] musicInfoArray = new String[80];

            Console.WriteLine("\n    MUSIC INFORMATION ");
            Console.Write("------------------------------\n\n"); 

            string readText = File.ReadAllText("music.txt");  // Test to read the txt file contents
            Console.WriteLine(readText);

            for (int index = 0; index < musicInfoArray.Length; index++)
            {
                musicInfoArray[index] = new UpMusicInfo();
            }     
                
        }
    }
}