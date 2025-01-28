using System.Runtime.InteropServices;

namespace Assignment
{
    internal class Program
    {
        static void CountGreaterNums(int[] arr, int[]queries)
        {
            for (int i = 0; i < queries.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr is not null && queries is not null)
                    {
                        if (arr[j] > queries[i])
                            count++;
                    }                   
                }
                Console.WriteLine(count);
            } 
        }
        static void CheckPalindrom(int[] arr, int num)
        {
            int count = 0;
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    count++;
                }
                if(count == num)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {
            #region Q01-GreaterThanQueries
            int[] arr = { 3, 5, 11 };
            int[] queries = { 1, 5, 13 };
            //CountGreaterNums(arr, queries); 
            #endregion

            #region Q2-Palindrome
            int[] Numbers = { 1, 2, 3, 2, 1 };
            CheckPalindrom(Numbers, 5);
            #endregion
        }
    }
}
