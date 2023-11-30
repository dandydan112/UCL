namespace SortAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Array sort in asscending order");
            foreach (var item in intArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}