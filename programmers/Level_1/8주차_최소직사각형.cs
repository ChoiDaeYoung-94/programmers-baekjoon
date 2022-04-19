using System;

public class Solution
{
    public int solution(int[,] sizes)
    {
        int answer = OptimalSize(sizes);
        return answer;
    }

    int OptimalSize(int[,] sizes)
    {
        int maxW = 0, maxH = 0;
        for (int i = -1; ++i < sizes.GetLength(0);)
        {
            int temp_w = sizes[i, 0];
            int temp_h = sizes[i, 1];

            if (temp_h > temp_w)
            {
                sizes[i, 0] = temp_h;
                sizes[i, 1] = temp_w;
            }

            if (sizes[i, 0] > maxW) maxW = sizes[i, 0];
            if (sizes[i, 1] > maxH) maxH = sizes[i, 1];
        }

        return maxW * maxH;
    }
}