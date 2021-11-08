public class Solution
{
    int[] answer = new int[] { 0, 0 };

    public int[] solution(int[,] arr)
    {
        QuadtreeCompress(arr, 0, 0, arr.GetLength(0));

        return answer;
    }

    void QuadtreeCompress(int[,] arr, int x_S, int y_S, int length)
    {
        bool zero = true, one = true;

        for (int i = x_S; i < x_S + length; i++)
            for (int j = y_S; j < y_S + length; j++)
            {
                if (arr[i, j] == 0) one = false;
                if (arr[i, j] == 1) zero = false;
            }

        if (zero)
            answer[0] += 1;

        if (one)
            answer[1] += 1;

        if (zero || one)
            return;

        QuadtreeCompress(arr, x_S, y_S, length / 2);
        QuadtreeCompress(arr, x_S, y_S + length / 2, length / 2);
        QuadtreeCompress(arr, x_S + length / 2, y_S, length / 2);
        QuadtreeCompress(arr, x_S + length / 2, y_S + length / 2, length / 2);
    }
}