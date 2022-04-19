using System;

public class Solution
{
    string Change(string num)
    {
        if (num == "zero") return "0";
        if (num == "one") return "1";
        if (num == "two") return "2";
        if (num == "three") return "3";
        if (num == "four") return "4";
        if (num == "five") return "5";
        if (num == "six") return "6";
        if (num == "seven") return "7";
        if (num == "eight") return "8";
        if (num == "nine") return "9";
        return null;
    }

    public int solution(string s)
    {
        int answer = 0;

        string _tempNum = "";
        string _tempStr = "";
        for (int i = -1; ++i < s.Length;)
        {
            if (int.TryParse(s[i].ToString(), out int temp)) _tempNum += s[i];
            else _tempStr += s[i];

            if (_tempStr != "")
                if (Change(_tempStr) != null)
                {
                    _tempNum += Change(_tempStr);
                    _tempStr = "";
                }
        }

        answer = Convert.ToInt32(_tempNum);
        return answer;
    }
}