using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    string Grade(int avr)
    {
        string grade = "";
        switch (avr)
        {
            case 9:
                grade = "A";
                break;
            case 8:
                grade = "B";
                break;
            case 7:
                grade = "C";
                break;
            case 6:
                grade = "D";
                break;
            case 5:
                grade = "D";
                break;
            default:
                grade = "F";
                break;
        }
        return grade;
    }

    public string solution(int[,] scores)
    {
        string answer = "";

        int size = scores.GetLength(0);
        int[,] score = new int[size, size];

        for (int i = -1; ++i < size;)
        {
            for (int j = -1; ++j < size;)
                if (j != i) score[j, i] = scores[i, j];
        }

        for (int i = -1; ++i < size;)
        {
            List<int> temp = new List<int>();

            for (int j = -1; ++j < size;)
                if (i != j) temp.Add(score[i, j]);

            if (temp.Max() >= scores[i, i] && temp.Min() <= scores[i, i])
                temp.Add(scores[i, i]);

            answer += Grade((int)temp.Average() / 10);
        }

        return answer;
    }
}