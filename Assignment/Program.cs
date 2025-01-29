using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void CountGreaterNums(int[] arr, int[] queries)
        {
            for (int i = 0; i < queries.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr is not null && queries is not null)
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
                if (count == num)
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
            while (stack.Count > 0)
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
        static void CheckIfBalanced(Stack<char> S)
        {
            while (S.Count > 0)
            {
                foreach (char c in S)
                {
                    if (c == '[' || c == '{' || c == '(')
                        S.Push(c);
                    else if (c == ']' || c == '}' || c == ')')
                        if (S.Count == 0 || S.Pop().Equals('[') || S.Pop().Equals('{') || S.Pop().Equals('('))
                            break;
                }
            }
        }
        static List<T> RemoveDuplicate<T>(List<T> list)
        {
            HashSet<T> values = new HashSet<T>();
            List<T> newList = new List<T>();
            if (list == null)
                return null;
            else
            {
                foreach (T i in list)
                {
                    if (values.Add(i))
                    {
                        newList.Add(i);
                    }
                }
                return newList;
            }
        }
        static void PrintList<T>(List<T> L)
        {
            foreach (T i in L)
            {
                Console.WriteLine(i + " ");
            }
        }
        static ArrayList RemoveOdd(ArrayList arrList)
        {
            for (int i = 0; i < arrList.Count; i++)
            {
                if ((int)arrList[i] % 2 != 0)
                {
                    arrList.RemoveAt(i);
                }
            }
            return arrList;
        }
        static void PrintArrList(ArrayList arrayList)
        {
            foreach (int i in arrayList)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            #region Q01-GreaterThanQueries
            //int[] arr = { 3, 5, 11 };
            int[] queries = { 1, 5, 13 };
            //CountGreaterNums(arr, queries); 
            #endregion

            #region Q2-Palindrome
            //int[] Numbers = { 1, 2, 3, 2, 1 };
            //CheckPalindrom(Numbers, 5);
            #endregion

            #region Q03-ReverseFromQueueToStack
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //Console.WriteLine("Before the Reverse : ");
            //PrintQueue(queue);
            //ReverseElements(queue);
            //Console.WriteLine("After the Reverse : ");
            //PrintQueue(queue);
            #endregion

            #region Q04-Parentheses is Balanced
            Stack<char> stack = new Stack<char>();//[()]{}
                                                  //stack.Push('[');
                                                  //stack.Push(']');
                                                  //stack.Push('{');
                                                  //stack.Push('}');
                                                  //stack.Push('(');
                                                  //stack.Push(')');
                                                  //CheckIfBalanced(stack);
            #endregion

            #region Q05-Duplicate Elements
            List<int> list = new List<int>() { 1, 2, 3, 2, 4, 4 };
            //List<int> Result = RemoveDuplicate(list);
            //PrintList(Result);
            #endregion

            #region Q06-Remove Odd Numbers
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //ArrayList newArrList = RemoveOdd(arrayList);
            //PrintArrList(newArrList);
            #endregion

            #region Q07-Queue Different Data Type
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine($"item is : {item}");
            //}
            #endregion
        }
    }
}
