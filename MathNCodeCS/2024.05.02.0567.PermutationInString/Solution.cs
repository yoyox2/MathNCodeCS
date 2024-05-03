namespace MathNCodeCS._2024._05._02._0567.PermutationInString;

// 567 Permutation in String
// https://leetcode.com/problems/permutation-in-string

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        //passed: 66ms
        if (s1.Length > s2.Length)
            return false;

        int k = s1.Length;
        var counter1 = s1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());      // s1의 counter
        var counter2 = s2[..k].GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()); // s2의 첫 k character counter

        int matchCount = 0;
        // int matchTarget = k;
        int matchTarget = counter1.Count;

        foreach ((char key, int cnt1) in counter1)
        {
            if (counter2.TryGetValue(key, out int cnt2) && cnt1 == cnt2)
                matchCount++;
        }

        if (matchCount == matchTarget)
            return true;

        for (int right = k; right < s2.Length; right++)
        {
            int left = right - k;
            char a = s2[left];
            char b = s2[right];

            if (a == b)
                continue;

            counter2[a] -= 1;
            counter2[b] = 1 + counter2.GetValueOrDefault(b, 0);

            // matchCount 를 업데이트
            if (counter1.ContainsKey(a))
            {
                if (counter1[a] == counter2[a])
                    matchCount++;
                else if (counter1[a] - 1 == counter2[a])
                    matchCount--;
            }

            if (counter1.ContainsKey(b))
            {
                if (counter1[b] == counter2[b])
                    matchCount++;
                else if (counter1[b] + 1 == counter2[b])
                    matchCount--;
            }

            if (matchCount == matchTarget)
                return true;
        }

        return false;

        //passed: 73ms

        //if (s1.Length > s2.Length)
        //    return false;

        //int k = s1.Length;
        //var counter1 = s1.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());      // s1의 counter
        //var counter2 = s2[..k].GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count()); // s2의 첫 k character counter

        //if (Matches())
        //    return true;

        //for (int right = k; right < s2.Length; right++)
        //{
        //    int left = right - k;
        //    char a = s2[left];
        //    char b = s2[right];

        //    if (a == b)
        //        continue;

        //    counter2[a] -= 1;
        //    counter2[b] = 1 + counter2.GetValueOrDefault(b, 0);

        //    if (Matches())
        //        return true;
        //}

        //return false;

        //bool Matches()
        //{
        //    foreach ((char key, int cnt1) in counter1)
        //    {
        //        if (!counter2.TryGetValue(key, out int cnt2) || cnt1 != cnt2)
        //            return false;
        //    }

        //    return true;
        //}


        //passed: 2000ms, O(N^2)

        //string x1 = string.Join("", s1.Order());
        //for (int i = 0; i <= s2.Length - s1.Length; i++)
        //{
        //    string x2 = s2.Substring(i, s1.Length);
        //    if (x1 == string.Join("", x2.Order()))
        //        return true;
        //}

        //return false;
    }
}
