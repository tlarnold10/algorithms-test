using System;

// Is Unique: Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures? 


namespace isUnique
{
    class isUnique
    {
        public static Boolean HasDuplicateNumbers(int[] arr)
        {
            int indexCounter = 0;
            Array.Sort(arr);
            foreach (int num in arr)
            {
                if (indexCounter == arr.Length)
                {
                    return (true);
                }
                else 
                {
                    if (arr[indexCounter] == arr[indexCounter+1])
                    {
                        return (false);
                    }
                }
                indexCounter = indexCounter + 1;
            }
            return (true);
        }
        public static void Main(string[] args)
        {
            int[] testArray = {1, 2, 3, 6, 2, 34, 2, 44, 22, 455};
            Console.WriteLine(HasDuplicateNumbers(testArray));
        }

        
    }
}