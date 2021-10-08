using System.Text;

public class Solution
{
    public string solution(string s, int n)
    {
        StringBuilder answer = new StringBuilder();

        for (int i = -1; ++i < s.Length;)
        {
            int temp = s[i];

            if (s[i] == ' ')
            {
                answer.Append(" ");
                continue;
            }

            if (temp >= 'a' && temp <= 'z')
            {
                temp += n % 26;
                if (temp > 'z') temp -= 26;
            }

            if (temp >= 'A' && temp <= 'Z')
            {
                temp += n % 26;
                if (temp > 'Z') temp -= 26;
            }

            answer.Append((char)temp);
        }

        return answer.ToString();
    }
}