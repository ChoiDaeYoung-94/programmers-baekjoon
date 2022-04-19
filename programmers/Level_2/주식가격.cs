using System;

public class Solution
{
    public int[] solution(int[] prices)
    {
        int length = prices.Length;
        int[] answer = new int[length];

        for (int i = -1; ++i < length;)
            for (int j = i; ++j < length;)
            {
                answer[i] += 1;

                if (prices[j] < prices[i])
                    break;
            }

        return answer;
    }
}