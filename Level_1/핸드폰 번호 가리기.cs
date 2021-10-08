using System.Text;

public class Solution
{
    public string solution(string phone_number)
    {
        StringBuilder answer = new StringBuilder();

        for (int i = 0; i < phone_number.Length; i++)
        {
            char num = i < phone_number.Length - 4 ? '*' : phone_number[i];
            answer.Append(num);
        }

        return answer.ToString();
    }
}