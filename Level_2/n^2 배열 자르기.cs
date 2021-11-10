public class Solution
{
    public int[] solution(int n, long left, long right)
    {
        int[] answer = new int[right - left + 1];

        int indexAnswer = 0;

        for (long i = left / n; ++i <= n;)
        {
            if (indexAnswer == answer.Length)
                break;

            long index = 0;
            if (i == left / n + 1)
                index = left % n;

            for (long j = index; ++j <= n;)
            {
                int num = (int)j;
                if (num < (int)i)
                    num = (int)i;

                answer[indexAnswer++] = num;
                if (indexAnswer == answer.Length)
                    break;
            }
        }

        return answer;
    }
}