
namespace ConsoleApp1
{
    public class StairCase
    {
        //input: number
        //output:
        //#
        //##
        //###
        //####
        public static void startCase(int n)
        {
            string spaces;
            string stars;
            string result;
            if (0 < n && n <= 100)
            {
                for (int i = 0; i < n; ++i)
                {
                    spaces = new string(' ', n - i - 1);
                    stars = new string('#', i + 1);
                    result = spaces + stars;
                    if (i == n - 1)
                    {
                        result = result.TrimStart(' ');
                    }
                    Console.WriteLine(result);
                }
            }
        }
    }
}
