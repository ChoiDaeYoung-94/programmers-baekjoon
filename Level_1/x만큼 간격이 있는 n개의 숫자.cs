using System.Collections.Generic;

public class Solution
{
    public long[] solution(int x, int n)
    {
        List<long> answer = new List<long>();
        long su = x;
        for (int i = 0; i < n; i++)
        {
            answer.Add(su);
            su += x;
        }
        return answer.ToArray();
    }
}