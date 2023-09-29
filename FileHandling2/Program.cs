using System.IO;
using System;

class Example
{
    public static void Main()
    {
        DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\sport\Documents\ACS\Others\example");

        currDir.Create();

        string path = @"C:\Users\sport\Documents\ACS\Others\example\YourName.txt";

        if (!File.Exists(path))
        {
            File.Create(path);
        }
        

        Console.WriteLine("Type text: ");
        string input = (Console.ReadLine());
        string[] text = { input };

        if (input.Contains('M'))
        {
            File.WriteAllLines(path, text);
        }
       else
        {
         File.WriteAllText(path, string.Empty);
        }

        foreach (string item in File.ReadAllLines(path))
        {
            Console.WriteLine(item);
        }


        FileInfo[] txtFiles = currDir.GetFiles("*.txt", SearchOption.AllDirectories);

        foreach (var j in txtFiles) 
        {
            Console.WriteLine($"Date the file was created: {j.CreationTime}" );
            Console.WriteLine($"Directory name: {j.FullName}");
            Console.WriteLine($"Full name of the file: {j.Name}");
            Console.WriteLine($"Last access time of the file: {j.LastAccessTime}");
        }
       
       
    }


}
