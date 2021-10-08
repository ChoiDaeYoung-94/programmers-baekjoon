using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int divisor)
    {
        int[] answer = new int[] { };

        List<int> temp = new List<int>();
        foreach (int item in arr)
            if (item % divisor == 0) temp.Add(item);

        if (temp.Count == 0) temp.Add(-1);

        answer = temp.OrderBy(x => x).ToArray();

        return answer;
    }
}