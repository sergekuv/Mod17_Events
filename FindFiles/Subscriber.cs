namespace FindFiles;

class Subscriber
{
    private readonly string _id;

    public Subscriber(FileFinder pub)
    {
        pub.FileFound += HandleFileFoundEvent;
    }

    void HandleFileFoundEvent(object sender, FileEventArgs e)
    {
        Console.WriteLine($"File found: {e.FileName}");
    }
}