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
            List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");

            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] {3,4});

            Numbers.Add(6);
            Numbers.TrimExcess(); //  DeAllocate
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine($"Count : {Numbers.Count} , Capacity : {Numbers.Capacity}");

            Numbers[0] = 100;  // Use Indexer as Setter
            //Console.WriteLine(Numbers[0]);//Use Indexer as Getter

            //Console.WriteLine($"Sum is : {SumArrayList(Numbers)}");
            #endregion
        }
    }
}
