using System.Collections;
namespace Demo
{
    internal class Program
    {
        public static int SumArrayList(List<int> array)
        {
            int sum = 0;
            if (array != null)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region NonGenaric Collections - ArrayLists
            //ArrayList arrayList = new ArrayList();

            //Console.WriteLine($"Count : {arrayList.Count} , Capacity : {arrayList.Capacity}");
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine($"Count : {arrayList.Count} , Capacity : {arrayList.Capacity}");
            //arrayList.Add(5);
            //Console.WriteLine($"Count : {arrayList.Count} , Capacity : {arrayList.Capacity}");

            //ArrayList arrayList = new ArrayList(10) { 1,2,3,4,5,};
            //arrayList.Add(6);
            //arrayList.TrimToSize();// Delete UnUsed Bytes
            //Console.WriteLine($"Count : {arrayList.Count} , Capacity : {arrayList.Capacity}");

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.Add(3);
            //SumArrayList(arrayList);
            #endregion

            #region Genaric Collections - Lists
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");

            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] {3,4});

            //Numbers.Add(6);
            //Numbers.TrimExcess(); //  DeAllocate
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");

            //Numbers[0] = 100;  // Use Indexer as Setter
            //Console.WriteLine(Numbers[0]);//Use Indexer as Getter

            //Console.WriteLine($"Sum is : {SumArrayList(Numbers)}");
            #endregion

            #region Lists Methods
            //List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5 };
            //Numbers.Insert(Numbers[0], 100);
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("======");
            //Numbers.InsertRange(Numbers[3], new int[] { 7, 8, 9 });
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Numbers.Clear();
            //Numbers.Contains(3);
            //Numbers.EnsureCapacity(20);

            //int[] Nums = new int[20];
            //Numbers.CopyTo(Nums);
            //foreach (int i in Nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Numbers.CopyTo(Nums, 4);
            //foreach (int i in Nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Numbers.CopyTo(3, Nums, 4, 2);
            //foreach (int i in Nums)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Generic Collections - Other Lists
            LinkedList<int> list = new LinkedList<int>(); // Nodes 

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek()); ==> Top Element

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek()); ==> Front Element
            #endregion
        }
    }
}
