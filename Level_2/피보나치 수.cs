using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        List<int> _list = new List<int>();
        _list.Add(0); _list.Add(1);
        for (int i = 1; ++i < n;)
        {
            int count = _list.Count;
            _list.Add(_list[count - 1] % 1234567 + _list[count - 2] % 1234567);
        }

        return (_list[_list.Count - 1] + _list[_list.Count - 2]) % 1234567;
    }
}