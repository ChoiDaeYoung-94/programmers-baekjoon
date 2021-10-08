using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        string temp = "";

        while (n != 0)
        {
            temp += (n % 3).ToString();
            n /= 3;
        }

        char[] chr_temp = long.Parse(temp).ToString().ToCharArray();
        Array.Reverse(chr_temp);
        temp = new string(chr_temp);

        for (int i = -1; ++i < temp.Length;)
            answer += int.Parse(temp[i].ToString()) * (int)Math.Pow(3, i);

        return answer;
    }
}