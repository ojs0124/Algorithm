using System;

public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = {};
        
        if(l % 5 != 0){
            l += (5 - l % 5);
        }
        
        for(int i = l; i <= r; i = i+5){
            int num = i;
            
            while(num > 0){
                if(num % 10 != 0 && num % 10 != 5){
                    break;
                }
                
                num /= 10;
            }
            
            if(num == 0){
                Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = i;
            }
        }
        
        if(answer.Length == 0){
            Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = -1;
        }
        
        return answer;
    }
}
