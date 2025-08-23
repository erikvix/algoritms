namespace DivideAndConquest
{
    public class DivideAndConquest
    {
        public static void Main(string[] args)
        {
            int[] array = [2, 4, 6];

            int result = SumDNC(array);
            Console.WriteLine(result);
        }
        public static int SumDNC(int[] arr, int index = 0)
        {
            if (index >= arr.Length)
            {
                return 0;
            }
            return arr[index] + SumDNC(arr, index + 1);
        }
    }
}