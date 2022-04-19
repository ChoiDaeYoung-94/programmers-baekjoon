class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = 0;
        long sum = 0;

        for (long i = 0; ++i <= count;)
            sum += price * i;

        answer = money > sum ? 0 : sum - money;

        return answer;
    }
}