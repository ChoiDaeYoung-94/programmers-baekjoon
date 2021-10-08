using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int[] lost, int[] reserve)
    {
        int answer = 0;

        List<int> _lost = lost.ToList();
        List<int> _reserve = reserve.ToList();
        _lost.Sort(); _reserve.Sort();

        for (int i = -1; ++i < lost.Length;)
            for (int j = -1; ++j < reserve.Length;)
            {
                if (lost[i] == reserve[j])
                {
                    _lost.Remove(lost[i]);
                    _reserve.Remove(lost[i]);
                }
            }

        answer = n - _lost.Count;

        for (int i = -1; ++i < _lost.Count;)
            for (int j = -1; ++j < _reserve.Count;)
            {
                int range = _lost[i];

                if (_reserve.Contains(range - 1))
                {
                    _reserve.Remove(range - 1);
                    ++answer;
                    break;
                }
                else if (_reserve.Contains(range + 1))
                {
                    _reserve.Remove(range + 1);
                    ++answer;
                    break;
                }
            }

        return answer;
    }
}