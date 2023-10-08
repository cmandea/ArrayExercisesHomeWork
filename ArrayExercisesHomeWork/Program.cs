namespace ArrayExercisesHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = ConsoleClass.ReadNumber("The size of array=", 3, 0);
            int nrforOccurrance= ConsoleClass.ReadNumber("Please enter number for count of occurrance=", 3, 0);
            int[] array = new int[size];

            for (int i = 0;i < array.Length;i++) 
            {
                int item = ConsoleClass.ReadNumber($"Element[{i}]=", 3, 0);
                array[i] = item;
            }
            ConsoleClass.PrintArray("Array=", array);
            
            int minValue=ArrayClass.MinValueOfArray(array);
            Console.WriteLine($"MinValueOfArray={minValue}");
            
            int maxValue =ArrayClass.MaxValueOfArray(array);
            Console.WriteLine($"MaxValueOfArray={maxValue}");

            int sumValue = ArrayClass.SumValueOfArray(array);
            Console.WriteLine($"SumValuesOfArray={sumValue}");

            double averageValues = sumValue / size;
            Console.WriteLine($"averageValues={averageValues}");

            string revArray = ArrayClass.ReverseArray(array);
            Console.WriteLine($"Reverse array:[{revArray}]");

            int numberOcc = ArrayClass.CountOfOccurrence(array, nrforOccurrance);
            Console.WriteLine($"Number of occurrance for {nrforOccurrance}  is {numberOcc}");


        }
    }
}