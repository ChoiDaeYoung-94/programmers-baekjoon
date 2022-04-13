using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] id_list, string[] report, int k)
    {
        int[] answer = new int[id_list.Length];
        Dictionary<string, List<string>> _dic_report = new Dictionary<string, List<string>>();
        Dictionary<string, int> _dic_count = new Dictionary<string, int>();
        Dictionary<string, int> _dic_result = new Dictionary<string, int>();

        for (int i = -1; ++i < id_list.Length;)
        {
            _dic_report.Add(id_list[i], new List<string>());
            _dic_count.Add(id_list[i], 0);
            _dic_result.Add(id_list[i], 0);
        }

        foreach (string content in report)
        {
            string[] strA_temp = content.Split(' ');
            List<string> list_temp = _dic_report[strA_temp[1]];
            if (!list_temp.Contains(strA_temp[0]))
                list_temp.Add(strA_temp[0]);

            _dic_report[strA_temp[1]] = list_temp;
        }

        for (int i = -1; ++i < id_list.Length;)
        {
            string id = id_list[i];
            _dic_count[id] = _dic_report[id].Count;
        }

        for (int i = -1; ++i < id_list.Length;)
        {
            if (_dic_count[id_list[i]] >= k)
            {
                List<string> list_temp = _dic_report[id_list[i]];
                foreach (string id in list_temp)
                {
                    _dic_result[id] += 1;
                }
            }
        }

        int index = -1;
        foreach (int count in _dic_result.Values)
            answer[++index] = count;

        return answer;
    }
}