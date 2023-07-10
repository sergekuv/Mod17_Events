namespace FindFiles;

public class Program
{
    static void Main()
    {
        const string defaultPath = @"c:\T\TestFolder";
        Console.WriteLine("Looking for files inside a folder using a non-recursive way.\nDefault path is " + defaultPath);
        Console.Write("Enter a path where files are located (or press enter to use default path): ");
        string path = Console.ReadLine();

        try
        {
            var fileFinder = new FileFinder(string.IsNullOrWhiteSpace(path) ? defaultPath : path);
            var subscriber = new Subscriber(fileFinder);

            fileFinder.FindFiles();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Finished. Press any key to continue...");
        Console.ReadLine();
    }
}

