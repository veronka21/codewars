using System.Linq;
using System;
using System.Collections.Generic;

namespace Codewars
{
    class WhereMyAnagramsAt
    {
        public static List<string> Anagrams(string input, List<string> words)
        {
            return words.Where(word => SortString(word) == SortString(input)).ToList();
        }

        public static string SortString(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            return String.Join("", chars);
        }
    }
}
