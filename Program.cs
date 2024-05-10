namespace SortingAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 25, 32, 7, 1, 10, 55, 77, 40 };
            foreach (int i in arr)
            {
                System.Console.Write(i + " ");
            }
            BubbleSort.Sort(arr);
            System.Console.WriteLine("\nSorted Array : ");
            foreach (int i in arr)
            {
                System.Console.Write(i + " ");
            }

        }
    }
}
