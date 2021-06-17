using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using the System.IO.FileInfo
            // File class has static method
            // whereas the FileInfo class has instance (non-static methods)

            // get the path to the file
            string path = @"C:\Users\divya\source\repos\Files\Messages.txt";

            // operate on the file using the FileInfo class
            // 1. File class
            bool fileExists = File.Exists(path);

            // 2. FileInfo class
            FileInfo fileObject = new FileInfo(path);
            bool fileInfoExists = fileObject.Exists;

            // CRUD - Create Read Update Delete
            // Create a new file
            // using the File class
            FileStream file = File.Create(
                    @"C:\Users\divya\source\repos\Files\Errors.txt",
                    128,
                    FileOptions.None
                );

            if(File.Exists(@"C:\Users\divya\source\repos\Files\Errors.txt"))
            {
                Console.WriteLine("The file was created!");
            }
        }
    }
}
