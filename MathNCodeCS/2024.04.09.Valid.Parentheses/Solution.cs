namespace MathNCodeCS._2024._04._09.Valid.Parentheses;

// 20 Valid Parentheses
// https://leetcode.com/problems/valid-parentheses/

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> parenthesesStack = new Stack<char>();

        foreach (char c in s)
        {
            char checkP;
            switch (c)
            {
                case '(':
                case '[':
                case '{':
                    parenthesesStack.Push(c);
                    break;
                case ')':
                case ']':
                case '}':

                    // if any closing parentheses only exists
                    if (parenthesesStack.Count < 1)
                    {
                        return false;
                    }

                    checkP = parenthesesStack.Pop();

                    if (!(c == ')' && checkP == '(' || c == ']' && checkP == '[' || c == '}' && checkP == '{'))
                    {
                        return false;
                    }

                    break;
            }
        }

        if (parenthesesStack.Count() > 0)
        {
            return false;
        }

        return true;
    }
}
