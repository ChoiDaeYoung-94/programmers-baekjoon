using System;

public class Solution
{
    public int solution(string dirs)
    {
        int answer = 0;
        int[,,,] _check = new int[11, 11, 11, 11];
        int _x = 5, _y = 5;

        for (int i = -1; ++i < dirs.Length;)
        {
            int oldX = _x, oldY = _y;
            char direction = dirs[i];

            if (direction == 'U') ++_y;
            if (direction == 'D') --_y;
            if (direction == 'R') ++_x;
            if (direction == 'L') --_x;

            _x = MaxOrMin(_x);
            _y = MaxOrMin(_y);

            if (oldX != _x || oldY != _y)
                if (_check[oldX, oldY, _x, _y] == 0)
                {
                    _check[oldX, oldY, _x, _y] = 1;
                    _check[_x, _y, oldX, oldY] = 1;
                    ++answer;
                }
        }

        return answer;
    }

    int MaxOrMin(int num)
    {
        if (num >= 10) return 10;
        if (num <= 0) return 0;
        return num;
    }
}