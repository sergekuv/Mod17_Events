using MaxElement.Utilities;
using Mod17_Events.Examples;

namespace Mod17_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 7, 3, 5 };
            Utilities.Process(intArr, ConvertToFloat.IntToFloat);

            string[] stringArr = { "a", "mnhhh", "mm", "99" };
            Utilities.Process(stringArr, ConvertToFloat.StringToFloat);

            Person[] personArr = {
                new Person { Name = "Alex", BirthDate = new DateOnly(2002, 12, 22)},
                new Person { Name = "Mike", BirthDate = new DateOnly(1999, 1, 1) },
                new Person { Name = "Mike", BirthDate = new DateOnly(1979, 10, 10) },
            };
            Utilities.Process(personArr, ConvertToFloat.PersonToFloat);
        }
    }
}