namespace ConsoleApp1
{
    public class TimeConvert
    {
        //Given a time in 12-hour AM/PM format, convert it to military(24-hour) time.

        //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

        //exxample: 07:05:45PM => 19:05:45

        public static string TimeConversion(string s)
        {
            string result = "";
            var hour = s.Substring(0, 2);
            var timeSubString = s.Substring(2, 6);
            var parseToInt = Int32.Parse(hour);

            if (s.ToLower().Contains("pm"))
            {
                result = parseToInt + timeSubString;
                if (parseToInt != 12)
                {
                    result = $"{parseToInt + 12}" + timeSubString;
                }
            }

            else
            {
                if (parseToInt == 12)
                {
                    hour = "00";
                }
                result = hour + timeSubString;
            }

            return result;
        }
    }
}
