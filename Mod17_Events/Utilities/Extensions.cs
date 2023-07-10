using System.Collections;

namespace MaxElement.Utilities;

public static class Extensions
{
    //Возвращает максимальный элемент коллекции, используя метод, передаваемый в качестве параметра, для вычисления числового эквивалента элементов коллекции
    public static T GetMax<T>(this IEnumerable<T> e, Func<T, float> getParameter) //where T: class // проигнорируем требование задания, чтобы можно было работать и с int
    {
        T currentMaxItem = e.FirstOrDefault();
        float currentMaxFloat = getParameter(currentMaxItem);
        float currentFloat;

        foreach (var item in e)
        {
            currentFloat = getParameter(item);
            if (currentFloat > currentMaxFloat)
            {
                currentMaxFloat = currentFloat;
                currentMaxItem = item;
            }
        }

        return currentMaxItem;
    }

    public static void WriteAsString(this IEnumerable e)
    {
        foreach (var item in e)
        {
            Console.Write(item + "  ");
        }
        Console.WriteLine();
    }
}
