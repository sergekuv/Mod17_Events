namespace MaxElement.Utilities
{
    public static class Utilities
    {
        public static void Process<T>(IEnumerable<T> collection, Func<T, float> getParameter)
        {
            var maxItem = collection.GetMax(getParameter);
            Console.Write("\nIEnumerable: ");
            collection.WriteAsString();
            Console.WriteLine("Max: " + maxItem.ToString());
        }
    }
}
