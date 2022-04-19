public class Solution
{
    int GreatestCommonDivisor(int num_1, int num_2)
    {
        int swap;
        while (num_2 != 0)
        {
            swap = num_1 % num_2;
            num_1 = num_2;
            num_2 = swap;
        }
        return num_1;
    }

    int LeastCommonMultiple(int num_1, int num_2)
    {
        int i;
        for (i = 0; !(++i % num_1 == 0 && i % num_2 == 0);) ;
        return i;
    }

    public int[] solution(int n, int m)
    {
        int[] answer = new int[] { GreatestCommonDivisor(m, n), LeastCommonMultiple(n, m) };
        return answer;
    }
}