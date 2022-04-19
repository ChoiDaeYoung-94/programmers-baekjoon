using System;

public class Solution
{
    bool Divisor(int num)
    {
        int temp = 0;

        for (int i = 0; ++i <= num;)
            if (num % i == 0) ++temp;

        if (temp % 2 == 0) return true;
        else return false;
    }

    public int solution(int left, int right)
    {
        int answer = 0;

        for (int i = left; i <= right; i++)
        {
            if (Divisor(i)) answer += i;
            else answer -= i;
        }

        return answer;
    }
}