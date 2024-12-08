namespace Day05;

public static class ListExtension
{
    public static T CenterElement<T>(this List<T> list)
    {
        if (list.Count % 2 == 0)
        {
            throw new Exception();
        }

        return list[list.Count / 2];
    }
}