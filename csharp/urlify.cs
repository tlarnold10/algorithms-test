using System;

namespace urlify
{
    class urlify
    {
        public static String URLify(String str)
        {
            String newString = "";
            foreach (char character in str)
            {
                if (character == ' ')
                {
                    newString = newString + "%20";
                }
                else
                {
                    newString = newString + character;
                }
            }
            return (newString);
        }
        public static void Main(string[] args)
        {
            String testString = "The bees are in the trap";
            Console.WriteLine(URLify(testString));
        }

        
    }
}