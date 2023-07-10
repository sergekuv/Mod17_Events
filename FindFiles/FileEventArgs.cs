namespace FindFiles;

public class FileEventArgs : EventArgs
{
    public FileEventArgs(string fileName)
    {
        FileName = fileName;
    }

    public string FileName { get; set; }
}