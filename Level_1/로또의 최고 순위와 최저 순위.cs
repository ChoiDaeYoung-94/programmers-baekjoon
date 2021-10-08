using System;

public class Solution
{
    public int[] solution(int[] lottos, int[] win_nums)
    {
        Array.Sort(lottos); Array.Sort(win_nums);
        int[] answer = new int[2];
        int hit = 7, zero = 0;

        for (int i = -1; ++i < win_nums.Length;)
        {
            if (lottos[i] == 0) ++zero;

            for (int j = -1; ++j < lottos.Length;)
                if (win_nums[i] == lottos[j])
                {
                    --hit;
                    break;
                }
        }

        if (hit == 7) hit = 6;

        if (hit - zero < 1)
        {
            answer[0] = 1;
            answer[1] = hit;
        }
        else
        {
            answer[0] = hit - zero;
            answer[1] = hit;
        }

        return answer;
    }
}