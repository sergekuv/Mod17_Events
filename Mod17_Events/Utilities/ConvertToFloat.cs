using Mod17_Events.Examples;

namespace MaxElement.Utilities
{
    public static class ConvertToFloat
    {
        public static float IntToFloat(int input) => input;

        public static float DecToFloat(int input) => input;

        public static float StringToFloat(string input) => input.Length;

        public static float PersonToFloat(Person input) => input.BirthDate.Year * 100 + input.BirthDate.Month * 10 + input.BirthDate.Day;
    }
}
