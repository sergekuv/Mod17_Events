namespace FindFiles;

class FileFinder
{
    public event EventHandler<FileEventArgs> FileFound;
    public DirectoryInfo Dir { get; set; }

    public FileFinder(string path)
    {
        if (!Directory.Exists(path))
        {
            throw new DirectoryNotFoundException();
        }
        Dir = new DirectoryInfo(path);
    }

    public void FindFiles()
    {
        var files = Dir.GetFiles();
        foreach (var file in files)
        {
            if (file.Exists)
            {
                OnFileFoundEvent(new FileEventArgs(file.FullName));
                Thread.Sleep(1000);     //Замедляем процесс, чтобы можно было проверить проверить прерывания поиска (требование 4)
            }
            if (Console.KeyAvailable)
            {
                break;
            }
        }
    }

    protected virtual void OnFileFoundEvent(FileEventArgs e)
    {
        EventHandler<FileEventArgs> raiseEvent = FileFound;

        if (raiseEvent != null)
        {
            raiseEvent(this, e);
        }
    }
}
