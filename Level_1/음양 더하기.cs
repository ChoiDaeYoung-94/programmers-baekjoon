using System;

public class Solution
{
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0;

        for (int i = -1; ++i < absolutes.Length;)
        {
            if (signs[i]) answer += absolutes[i];
            else answer -= absolutes[i];
        }

        return answer;
    }
}