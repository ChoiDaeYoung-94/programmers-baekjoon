public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        for (int i = 0; ++i <= n;)
            if (n % i == 0) answer += i;

        return answer;
    }
}