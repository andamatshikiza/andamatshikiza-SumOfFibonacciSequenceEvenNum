using System;

namespace FibonacciSum
{
    class Program
    {

        static int SumOfEvnFibNum(long limit)
        {
            if (limit < 2) {
                return 0;
            }

            long num1 = 0;
            long num2 = 2;
            long sum = num1 + num2;

            while (num2 <= limit)
            {
                long num3 = 4 * num2 + num1;

                if (num3 > limit)
                    break;

                num1 = num2;
                num2 = num3;

                sum += num2;
            }

            return(int) sum;
            
        }
        static void Main(string[] args)
        {
            long limit = 5000000;
            Console.WriteLine(SumOfEvnFibNum(limit));
        }
    }
}
