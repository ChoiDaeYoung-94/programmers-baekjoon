using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers)
    {
        List<int> answer = new List<int>();

        for (int i = -1; ++i < numbers.Length;)
            for (int j = i + 1; j < numbers.Length; j++)
                answer.Add(numbers[i] + numbers[j]);

        return answer.Distinct().OrderBy(x => x).ToArray();
    }
}