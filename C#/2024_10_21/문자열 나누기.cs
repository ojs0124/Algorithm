using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int spellCount = 0;
        int otherCount = 0;
        
        char x = ' ';
        foreach(char c in s){
            if(x == ' ' || c == x){
                x = c;
                spellCount += 1;
            }
            else{
                otherCount += 1;
            }
            
            if(spellCount == otherCount){
                x = ' ';
                answer += 1;
                spellCount = 0;
                otherCount = 0;
            }
        }
        
        if(spellCount != 0 || otherCount != 0){
            answer += 1;
        }
        
        return answer;
    }
}
