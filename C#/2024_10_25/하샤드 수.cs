public class Solution {
    public bool solution(int x) {
        int hashad = 0, num = x;
        
        while(num != 0){
            hashad += num % 10;
            num /= 10;
        }
        
        return (x % hashad == 0) ? true : false;
    }
}
