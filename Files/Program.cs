using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. The PATH to the file
            // C:\Users\divya\source\repos\Files\Messages.txt
            // Absolute Path
            string path = @"C:\Users\divya\source\repos\Files\Messages.txt";

            // 2. A method from the System.IO.File class
            // a. File.Exists()
            bool fileExists = File.Exists(path);

            if(fileExists)
            {
                //Console.WriteLine("The File Exists!");
                // b. File.GetCreationTime()
                DateTime timeCreated = File.GetCreationTime(path);
                Console.WriteLine("The file was created at {0}", timeCreated);

                // c. File.GetLastAccessTime()
                DateTime lastAccessTime = File.GetLastAccessTime(path);

                // d. File.ReadAllText()
                // string fileContents = File.ReadAllText(path);

                // e. File.ReadAllBytes()
                // File.ReadAllBytes(path);

                // e. File.ReadAllLines()
                // File.ReadAllLines(path);

                // f. File.WriteAllText()
                File.WriteAllText(path, "Hello, this is a dummy content!");
                string fileContents = File.ReadAllText(path);
                Console.WriteLine(fileContents);
                File.WriteAllText(path, fileContents + "\nThis is the new content!");
                fileContents = File.ReadAllText(path);
                Console.WriteLine(fileContents);
            } 
            else
            {
                Console.WriteLine("The File Could Not Be Found!");
            }
        }
    }
}
