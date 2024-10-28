using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int commandCount = commands.GetLength(0);
        int[] answer = new int[commandCount];
        
        for (int index = 0; index < commandCount; index++)
        {
            // commands 배열에서 i, j, k 값을 가져오기
            int i = commands[index, 0];
            int j = commands[index, 1];
            int k = commands[index, 2];
            
            // 부분 배열 생성
            int[] newArray = new int[j - i + 1];
            Array.Copy(array, i - 1, newArray, 0, j - i + 1);
            
            // 부분 배열 정렬
            Array.Sort(newArray);
            
            // k번째 요소 추가
            answer[index] = newArray[k - 1];
        }

        return answer;
    }
}
