public class Solution
{
    public string solution(string s)
    {
        string answer = "";
        char[] chr_temp = s.ToCharArray();

        Array.Sort(chr_temp);
        Array.Reverse(chr_temp);

        answer = new string(chr_temp);

        return answer;
    }
}