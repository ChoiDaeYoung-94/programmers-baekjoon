using System;

public class Solution
{
    public bool solution(int x)
    {
        bool answer = true;
        string str_x = x.ToString();
        int su = 0;
        for (int i = 0; i < str_x.Length; i++) su += Int32.Parse(str_x[i].ToString());
        answer = x % su == 0 ? true : false;
        return answer;
    }
}