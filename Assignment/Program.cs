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
        static void ReverseElements(Queue<int> q)
        {
            Stack<int> stack = new Stack<int>();
            while (q.Count > 0)
            {
                stack.Push(q.Dequeue());
            }
            while(stack.Count > 0)
            {
                q.Enqueue(stack.Pop());
            }
        }
        static void PrintQueue(Queue<int> q)
        {
            foreach (int item in q)
            {
                Console.WriteLine(item);
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
            //CheckPalindrom(Numbers, 5);
            #endregion

            #region Q03-ReverseFromQueueToStack
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Before the Reverse : ");
            PrintQueue(queue);
            ReverseElements(queue);
            Console.WriteLine("After the Reverse : ");
            PrintQueue(queue);
            #endregion
        }
    }
}
