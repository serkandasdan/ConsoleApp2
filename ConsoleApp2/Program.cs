namespace ConsoleApp2
{
    class Result
    {
        public static int BeautifulDays(int i, int j, int k)
        {
            int sum = 0;

            for (int m = i; m <= j; m++)
            {
                int number2;
                var number = new string(m.ToString().Reverse().ToArray());
                number2 = Convert.ToInt32(number);
                if (number2 >= m)
                {
                    if ((number2 - m) % k == 0)
                    {
                        sum++;
                    }
                    else
                    {

                    }
                }
                else
                {
                    if ((m - number2) % k == 0)
                    {
                        sum++;
                    }
                    else
                    {

                    }
                }
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)

        {
           int result = Result.BeautifulDays(13 ,45 ,3);
            Console.WriteLine(result);
        }
    }
}
