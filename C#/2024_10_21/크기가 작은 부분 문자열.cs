using System;

public class Solution {
    public int solution(string t, string p) {
        int tLen = t.Length;
        int pLen = p.Length;
        
        int answer = 0;
        int count = tLen - pLen + 1;
        for(int i = 0; i < count; i++){
            string str = t.Substring(i, pLen);
            answer += (string.Compare(p, str) >= 0) ? 1 : 0;
        }
        
        return answer;
    }
}
