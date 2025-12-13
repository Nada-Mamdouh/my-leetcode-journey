using System.Text.RegularExpressions;
public class Solution {
    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive) {
        Dictionary<string, int> priority = new Dictionary<string, int> {
            { "electronics", 0 },
            { "grocery", 1 },
            { "pharmacy", 2 },
            { "restaurant", 3 }
        };

        List<(string Code, string Business)> validCoupons = new List<(string, string)>();

        for (int i = 0; i < code.Length; i++) {

            // Must be active
            if (!isActive[i]) continue;

            // Code validation
            if (string.IsNullOrEmpty(code[i])) continue;
            if (!Regex.IsMatch(code[i], "^[a-zA-Z0-9_]+$")) continue;

            // Business line validation
            if (!priority.ContainsKey(businessLine[i])) continue;

            validCoupons.Add((code[i], businessLine[i]));
        }

        // Sort by business line priority, then by code
        validCoupons.Sort((a, b) => {
            int cmp = priority[a.Business].CompareTo(priority[b.Business]);
            if (cmp != 0) return cmp;
            return string.Compare(a.Code, b.Code, StringComparison.Ordinal);
        });

        // Extract result
        List<string> result = new List<string>();
        foreach (var c in validCoupons) {
            result.Add(c.Code);
        }

        return result;
    }
    
}