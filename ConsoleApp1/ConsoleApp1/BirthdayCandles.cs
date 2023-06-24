namespace ConsoleApp1
{
    public class BirthdayCandles
    {
        //You are in charge of the cake for a child's birthday.
        //You have decided the cake will have one candle for each year of their total age.
        //They will only be able to blow out the tallest of the candles.
        //Count how many candles are tallest.

        //Example: [4,4,1,3] => output: number 4 is highest number and apprear two times => 2
        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            int sameCandles = 0;
            for (int i = candles.Count - 1; i >= 0; --i)
            {
                if (candles[i] == candles[candles.Count - 1])
                {
                    sameCandles++;
                }
            }
            return sameCandles;
        }
    }
}
