using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] weights, string[] head2head)
    {
        int _length = weights.Length;
        int[] answer = new int[_length];

        Dictionary<int, double[]> _table = Information(weights, head2head, _length);

        answer = SortTableToArray(_table);

        return answer;
    }

    Dictionary<int, double[]> Information(int[] weights, string[] head2head, int _length)
    {
        Dictionary<int, double[]> temp_dic = new Dictionary<int, double[]>();

        for (int i = -1; ++i < _length;)
        {
            double[] temp_double = new double[3];
            double W = 0; int N = 0, WW = 0;

            for (int j = -1; ++j < _length;)
            {
                temp_double[2] = weights[i];
                if (head2head[i][j] == 'W')
                {
                    ++W;
                    if (weights[i] < weights[j]) ++WW;
                }
                if (head2head[i][j] == 'N') ++N;
            }

            if (W == 0) W = 0;
            else W = W / (_length - N) * 100;
            temp_double[0] = W; temp_double[1] = WW;

            temp_dic.Add(i, temp_double);
        }

        return temp_dic;
    }

    int[] SortTableToArray(Dictionary<int, double[]> _table)
    {
        int[] temp_Array = _table.OrderByDescending(x => x.Value[0]).
            ThenByDescending(x => x.Value[1]).ThenByDescending(x => x.Value[2]).
            Select(x => x.Key + 1).ToArray();

        return temp_Array;
    }
}