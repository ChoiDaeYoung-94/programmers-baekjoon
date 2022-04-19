using System.Text;

public class Solution
{
    public int solution(string skill, string[] skill_trees)
    {
        int answer = 0;

        for (int i = -1; ++i < skill_trees.Length;)
        {
            string cur_skill = skill_trees[i];

            StringBuilder selectSkill = new StringBuilder();
            for (int j = -1; ++j < cur_skill.Length;)
                if (skill.Contains(cur_skill[j].ToString()))
                    selectSkill.Append(cur_skill[j].ToString());

            bool check = false;
            for (int x = -1; ++x < selectSkill.Length;)
                if (skill[x] != selectSkill[x])
                {
                    check = true;
                    break;
                }
            if (check)
                continue;

            ++answer;
        }

        return answer;
    }
}