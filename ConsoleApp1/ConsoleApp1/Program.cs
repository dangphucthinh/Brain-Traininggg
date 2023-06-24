using ConsoleApp1;

class Solution
{
    public static List<int> generateList(int count)
    {
        Random random = new Random();
        List<int> values = new List<int>();

        for (int i = 0; i < count; ++i)
            values.Add(random.Next());

        return values;
    }

    public static void Main(string[] args)
    {
        List<int> values = generateList(10);

    }
}
