using System;
using System.Linq;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];

        while (s != "1")
        {
            answer[0] += 1;

            int oldLength = s.Length;
            int temp = s.ToList().RemoveAll(x => x == '0');

            answer[1] += temp;

            s = Convert.ToString(oldLength - temp, 2);
        }

        return answer;
    }
}