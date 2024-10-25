using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] arr = new int[2];

        for (int div = 1; div <= Math.Sqrt(yellow); div++) {
            if (yellow % div == 0) {
                arr[0] = yellow / div;
                arr[1] = div;
            }

            if (brown == (arr[0] + arr[1] + 2) * 2) {
                arr[0] = arr[0] + 2;
                arr[1] = arr[1] + 2;
                return arr;
            }
        }

        return new int[2] { 0, 0 };
    }
}
