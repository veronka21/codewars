using System;
using System.Collections;

namespace Codewars
{
    class SimpleReversedParentheses
    {
        public static int solve(string s)
        {
            if (s.Length % 2 != 0) return -1;
            string copy = s;
            while (copy.Contains("()"))
            {
                copy = copy.Replace("()", "");
            }
            int counter = 0;
            Stack stack = new Stack();
            foreach (var ch in copy)
            {
                if (ch == ')' && stack.Count == 0)
                {
                    stack.Push('(');
                    counter++;
                } else if (ch == ')' && (char)stack.Peek() == '(') stack.Pop();
                else if (ch == '(' && stack.Count == 0) stack.Push('(');
                else if (ch == '(' && (char)stack.Peek() == '(')
                {
                    counter++;
                    stack.Pop();
                };
            }
            return counter;
        }
    }
}
