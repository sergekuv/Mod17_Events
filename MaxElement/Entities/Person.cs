namespace Mod17_Events.Examples;

public class Person
{
    public string Name { get; set; }
    public DateOnly BirthDate { get; set; }

    public override string ToString() => Name + " " + BirthDate.ToString();
}
