using System;

public class Solution
{
    public int solution(string word)
    {
        int answer = 0;
        string _useWords = "AEIOU";
        int[] _index = new int[_useWords.Length];

        _index[0] = 1;
        for (int i = 0; ++i < _index.Length;)
            _index[i] = _index[i - 1] * _useWords.Length + 1;

        Array.Reverse(_index);

        for (int i = -1; ++i < word.Length;)
        {
            int wordIndex = _useWords.IndexOf(word[i]);
            answer += wordIndex * _index[i] + 1;
        }

        return answer;
    }
}