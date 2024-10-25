using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) {
        bool answer;
        
        if(ineq + eq == ">="){
            answer = n >= m;
        }
        else if(ineq + eq == "<="){
            answer = n <= m;
        }
        else if(ineq + eq == ">!"){
            answer = n > m;
        }
        else{
            answer = n < m;
        }
        
        return answer ? 1 : 0;
    }
}
