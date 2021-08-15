public class Solution
{
    public int[,] solution(int[,] arr1, int[,] arr2)
    {
        int[,] answer = arr1;
        for (int i = 0; i < answer.GetLength(0); i++)
            for (int j = 0; j < answer.GetLength(1); j++)
                answer[i, j] += arr2[i, j];
        return answer;
    }
}