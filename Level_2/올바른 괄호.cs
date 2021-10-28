using System;

public class Solution
{
    public bool solution(string s)
    {
        bool answer = true;

        if (s[0] == ')' || s[s.Length - 1] == '(')
            return false;

        int _check = 0;
        for (int i = -1; ++i < s.Length;)
        {
            if (s[i] == '(') ++_check;
            if (s[i] == ')') --_check;

            if (_check < 0)
                return false;
        }

        if (_check != 0)
            return false;

        return answer;
    }
}