public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
            return false;
        
        var sDictionary = s
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        var tDictionary = t
            .GroupBy(c => c)
            .ToDictionary(g => g.Key, g => g.Count());

        if (sDictionary.Count != tDictionary.Count)
            return false;

        foreach (var kv in sDictionary)
        {
            if (!tDictionary.TryGetValue(kv.Key, out var count) 
                || count != kv.Value)
                return false;
        }

        return true;
    }
}