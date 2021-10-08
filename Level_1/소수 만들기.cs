using System;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;

        Array.Sort(nums);
        int max = nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3];

        List<bool> list_num = new List<bool>() { false, false };
        for (int i = 1; ++i <= max;) list_num.Add(true);
        for (int i = 1; ++i <= max;)
            if (list_num[i] == true)
            {
                for (int j = i * 2; j <= max; j += i)
                    list_num[j] = false;
            }

        for (int i = -1; ++i < nums.Length - 2;)
            for (int j = i + 1; j < nums.Length - 1; j++)
                for (int x = j + 1; x < nums.Length; x++)
                {
                    int sum = nums[i] + nums[j] + nums[x];
                    if (list_num[sum]) answer++;
                }

        return answer;
    }
}