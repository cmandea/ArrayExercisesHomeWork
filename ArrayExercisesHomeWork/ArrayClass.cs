
namespace ArrayExercisesHomeWork
{
    public static class ArrayClass
    {
        public static int MinValueOfArray(int[] array)
        {
            if (array is null) //test is NULL
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length == 0) // test is empty
            {
                throw new ArgumentException("Array must have at least 1 element!", nameof(array));
            }

            int minVal = array[0]; // baleez array-ul pornind de la prima pozitie in array si compar
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                }
            }
            return minVal;
        }

        public static int MaxValueOfArray(int[] array)
        {
            if (array is null) //test is NULL
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length == 0) // test is empty
            {
                throw new ArgumentException("Array must have at least 1 element!", nameof(array));
            }

            int maxVal = array[0]; // baleez array-ul pornind de la prima pozitie in array si compar
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            return maxVal;
        }

        public static int SumValueOfArray(int[] array)
        {
            if (array is null) //test is NULL
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length == 0) // test is empty
            {
                throw new ArgumentException("Array must have at least 1 element!", nameof(array));
            }
            int sum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;

        }

        public static string ReverseArray(int[] array)
        {
            if (array is null) //test is NULL
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length == 0) // test is empty
            {
                throw new ArgumentException("Array must have at least 1 element!", nameof(array));
            }
            string[] arrayRev =new string[array.Length];
            int arraySize = array.Length;
            
            for (int i = 0; i < arrayRev.Length; i++)

            {
                int j = arraySize - i;
                arrayRev[i] = array[j-1].ToString();
                
            }
            return string.Join(",", arrayRev);

        }


        public static int CountOfOccurrence(int[] array, int numberOccurrence)
        {
            if (array is null) //test is NULL
            {
                throw new ArgumentNullException(nameof(array));
            }
            if (array.Length == 0) // test is empty
            {
                throw new ArgumentException("Array must have at least 1 element!", nameof(array));
            }

                        
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //Console.WriteLine(array[i]);
                if (array[i] == numberOccurrence)
                {
                    j += 1;
                }
            }
            return j;

        }

    }
}


