using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int n, int[,] wires)
    {
        int answer = -1;
        int[] _count = new int[2];
        List<int> _link1 = new List<int>();
        List<int> _link2 = new List<int>();
        List<int> _abs = new List<int>();

        for (int i = 0; ++i < n;)
        {
            for (int j = -1; ++j < wires.GetLength(0);)
                if (wires[j, 0] == i)
                {
                    _link1.Add(wires[j, 1]);
                    GetAbs(wires, i, _link1, _count, 0);

                    _link2.Add(i);
                    GetAbs(wires, wires[j, 1], _link2, _count, 1);

                    _abs.Add(Math.Abs(_count[0] - _count[1]));

                    Array.Clear(_count, 0, 2);
                    _link1.Clear(); _link2.Clear();
                }
        }

        answer = _abs.Min();
        return answer;
    }

    void GetAbs(int[,] wires, int curV, List<int> link, int[] count, int index)
    {
        for (int j = -1; ++j < wires.GetLength(0);)
            if (wires[j, 0] == curV || wires[j, 1] == curV)
            {
                int next = wires[j, 0] == curV ? wires[j, 1] : wires[j, 0];

                if (!link.Contains(next))
                {
                    link.Add(curV);
                    count[index] += 1;
                    GetAbs(wires, next, link, count, index);
                }
            }
    }
}