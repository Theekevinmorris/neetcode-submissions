public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        for(int i = 0; i < arr.Length; i++){
            if(i == arr.Length - 1){
                arr[i] = -1;
                return arr;
            }

            arr[i] = 0;    
            for(int j = i + 1; j < arr.Length; j++){
                arr[i] = Math.Max(arr[i], arr[j]);
            }
        }

        return arr;
    }
}