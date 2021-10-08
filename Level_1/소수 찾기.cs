using System.Collections.Generic;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        List<bool> list_num = new List<bool>();

        list_num.Add(false);
        list_num.Add(false);

        for (int i = 2; i <= n; i++)
            list_num.Add(true);

        for (int i = 2; i <= n; i++)
            if (list_num[i])
            {
                for (int j = i * 2; j <= n; j += i)
                    list_num[j] = false;
            }

        foreach (bool item in list_num)
            if (item) ++answer;

        //for (int i = 2; i < list_num.Count; i++) if(list_num[i] == true) ++answer;

        return answer;
    }
}