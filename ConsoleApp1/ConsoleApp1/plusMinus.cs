namespace ConsoleApp1
{
    public class Bai2
    {
        //Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero.Print the decimal value of each fraction on a new line with  places after the decimal.

        //Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

        //example: 
        //input: size = 6,  arr = [-4, 3, -9, 0, 4, 1]
        // out put :
        // 0.500000 = 3/6
        //0.333333 = 2/6
        //0.166667 = 1/6

        // ==> giải thích: mảng trên có 3 số dương, 2 số âm và 1 số 0. In ra phần trăm của các số tương ứng với số lượng phần tử trong mảng.

        public static void plusMinus(int n, List<int> arr)
        {
            double positive = 0;
            double negative = 0;
            double zero = 0;
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    positive++;
                }
                if (i < 0)
                {
                    negative++;
                }
                if (i == 0)
                {
                    zero++;
                }
            }

            Console.WriteLine((positive / n).ToString("F6"));
            Console.WriteLine((negative / n).ToString("F6"));
            Console.WriteLine((zero / n).ToString("F6"));
        }
    }
}
