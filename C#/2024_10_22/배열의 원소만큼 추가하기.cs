using System;

public class Solution {
    public int[] solution(int[] arr) {
        int numCount = 0;
        foreach(int num in arr){
            numCount += num;
        }
        
        int index = 0;
        int[] answer = new int[numCount];
        foreach(int num in arr){
            int repeat = num;
            while(repeat > 0){
                answer[index] = num;
                index += 1;
                repeat -= 1;
            }
        }
        
        return answer;
    }
}
