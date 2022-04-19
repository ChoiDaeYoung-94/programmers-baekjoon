using System;

public class Solution
{
    public int[] solution(long n)
    {
        char[] chr = n.ToString().ToCharArray();
        int[] answer = new int[chr.Length];

        Array.Reverse(chr);

        for (int i = -1; ++i < chr.Length;)
        {
            int temp = Convert.ToInt32(chr[i].ToString());
            answer[i] = temp;
        }

        return answer;
    }
}