using System;
using System.Linq;

class Solution
{
    public int solution(int n)
    {
        int answer = n;
        int _count = Count(Convert.ToString(n, 2));

        while (true)
        {
            if (_count == Count(Convert.ToString(++answer, 2)))
                break;
        }

        return answer;
    }

    int Count(string str)
    {
        int count = 0;
        for (int i = -1; ++i < str.Length;)
            if (str[i] == '1')
                ++count;

        return count;
    }

    //.Where(x => x == '1').Count()
}