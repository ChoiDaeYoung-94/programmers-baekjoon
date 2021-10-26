using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string s)
    {
        string answer = "";

        List<int> _list =
            s.Split(' ').Select(x => System.Convert.ToInt32(x)).OrderBy(x => x).ToList();

        answer = _list.First() + " " + _list.Last();

        return answer;
    }
}