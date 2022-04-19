using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] answers)
    {
        List<int> answer = new List<int>();

        int[] people = new int[3] { 0, 0, 0 };
        int[] person_1 = new int[] { 1, 2, 3, 4, 5 };
        int[] person_2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        int[] person_3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

        for (int i = -1; ++i < answers.Length;)
        {
            if (answers[i] == person_1[i % 5]) ++people[0];
            if (answers[i] == person_2[i % 8]) ++people[1];
            if (answers[i] == person_3[i % 10]) ++people[2];
        }

        for (int i = -1; ++i < people.Length;)
            if (people[i] == people.Max()) answer.Add(i + 1);

        return answer.ToArray();
    }
}