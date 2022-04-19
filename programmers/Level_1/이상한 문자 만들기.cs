using System;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        int split = 0;
        for (int i = -1; ++i < s.Length;)
        {
            if (s[i] == ' ')
            {
                answer += " ";
                split = 0;
                continue;
            }

            string str = s[i].ToString();
            answer += split++ % 2 == 0 ? str.ToUpper() : str.ToLower();
        }

        return answer;
    }
}