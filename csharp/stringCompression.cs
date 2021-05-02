using System;
using System.Collections.Generic;

namespace stringCompression
{
    class stringCompression
    {
        public static String CompressString(String str)
        {
            String newString = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char character in str)
            {
                if (dict.ContainsKey(character))
                {
                    dict[character] = dict[character] + 1;
                }
                else
                {
                    dict[character] = 1;
                }
            }

            foreach (char key in dict.Keys)
            {
                newString = newString + key + dict[key].ToString();
            }

            return (newString);
        }
        public static void Main(string[] args)
        {
            String testString = "aaaasssddkkjqqkwwwll";
            Console.WriteLine(CompressString(testString));
        }

        
    }
}