using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = -1; ++i < answer.Length;)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1] - commands[i, 0] + 1;
            int choice = commands[i, 2] - 1;

            answer[i] = array.ToList().GetRange(start, end).OrderBy(x => x).ToArray()[choice];
        }

        return answer;
    }
}