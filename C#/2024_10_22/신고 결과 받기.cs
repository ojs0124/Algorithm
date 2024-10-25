using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        var reportCount = new Dictionary<string, int>();
        var reports = report.Distinct().ToList();
        var mail = new Dictionary<string, int>();
        
        foreach (var user in id_list)
        {
            mail[user] = 0;
        }
        
        foreach (var content in reports)
        {
            var parts = content.Split();
            var reportId = parts[1];

            if (reportCount.ContainsKey(reportId))
            {
                reportCount[reportId]++;
            }
            else
            {
                reportCount[reportId] = 1;
            }
        }
        
        var ban = new List<string>();
        foreach (var content in reportCount)
        {
            if (content.Value >= k)
            {
                ban.Add(content.Key);
            }
        }
        
        foreach (var content in reports)
        {
            var parts = content.Split();
            var userId = parts[0];
            var reportId = parts[1];

            if (ban.Contains(reportId))
            {
                mail[userId]++;
            }
        }
        
        return mail.Values.ToArray();
    }
}
