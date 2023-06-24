namespace ConsoleApp1
{
    public class mini_max_sum
    {
        //input: [1 ,3, 5, 7, 9]
        //output:  The minimum sum is 1+3+5+7=16  and the maximum sum is 3+5+7+9=24 . The function prints
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();
            long min = 0;
            long max = 0;
            for (int i = 0; i < arr.Count - 1; ++i)
            {
                min += arr[i];
                max += arr[i + 1];

            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
