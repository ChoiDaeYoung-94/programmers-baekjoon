using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int size = (arr.Length) > 0 ? arr.Length - 1 : 1;
        int[] answer = new int[size];

        if (size == 1)
        {
            answer[0] = -1;
            return answer;
        }
        else
        {
            int temp_min = arr.Min(), j = 0;
            for (int i = -1; ++i < arr.Length;)
                if (arr[i] != temp_min) answer[j++] = arr[i];
        }

        return answer;
    }
}