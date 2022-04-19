public class Solution
{
    public string solution(string[] seoul)
    {
        string answer = "";

        for (int i = -1; ++i < seoul.Length;)
            if (seoul[i] == "Kim") answer = "김서방은 " + i + "에 있다";

        return answer;
    }
}