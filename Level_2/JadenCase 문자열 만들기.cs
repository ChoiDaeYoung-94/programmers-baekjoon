using System.Text;

public class Solution
{
    public string solution(string s)
    {
        StringBuilder answer = new StringBuilder();
        string[] _splitS = s.ToLower().Split(new char[] { ' ' });

        for (int i = -1; ++i < _splitS.Length;)
        {
            if (_splitS[i] != "")
            {
                string first = _splitS[i].Substring(0, 1).ToUpper();

                if (_splitS[i].Length > 1)
                    answer.Append(first + _splitS[i].Substring(1) + " ");
                else
                    answer.Append(first + " ");
            }
            else
                answer.Append(" ");
        }
        answer.Remove(answer.Length - 1, 1);

        return answer.ToString();
    }
}