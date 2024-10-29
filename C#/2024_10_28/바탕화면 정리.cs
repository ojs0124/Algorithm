using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] wallpaper) {
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        
        int row = wallpaper.Length;
        int col = wallpaper[0].Length;
        
        for (int i = 0; i < row; i++){
            for (int j = 0; j < col; j++){
                if (wallpaper[i][j] == '#'){
                    x.Add(i);
                    y.Add(j);
                }
            }
        }
        
        if (x.Count == 0)
            return new int[] { 0, 0, 0, 0 };
        
        return new int[] { x.Min(), y.Min(), x.Max() + 1, y.Max() + 1 };
    }
}
