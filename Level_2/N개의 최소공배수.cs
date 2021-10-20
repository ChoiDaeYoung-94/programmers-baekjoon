public class Solution
{
    public int solution(int[] arr)
    {
        int answer = LeastCommonMultiple(arr);
        return answer;
    }

    int LeastCommonMultiple(int[] arr)
    {
        int lcm = 1;
        bool isFinished = false;

        while (!isFinished)
        {
            isFinished = true;

            for (int i = -1; ++i < arr.Length;)
                if (lcm % arr[i] != 0)
                {
                    ++lcm;
                    isFinished = false;
                }
        }

        return lcm;
    }
}