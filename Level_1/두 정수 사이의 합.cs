public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;

        (int small, int big) = a >= b ? (b, a) : (a, b);

        for (int i = small; i <= big; i++)
            answer += i;

        return answer;
    }
}