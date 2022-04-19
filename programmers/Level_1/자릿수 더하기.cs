using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        char[] chr = n.ToString().ToCharArray();

        foreach (char item in chr)
        {
            int temp = int.Parse(item.ToString());
            answer += temp;
        }

        return answer;
    }
}