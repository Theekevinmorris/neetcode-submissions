public class Solution {
    public int CalPoints(string[] operations) {
        int curPoints = 0;
        int prevScore = 0;
        int prevPrevScore = 0;

        for(int i = 0; i < operations.Length; i++){
            int curScore = 0;

            if(operations[i] == "+"){
                curScore = prevScore + prevPrevScore;
                curPoints += curScore;
                prevPrevScore = prevScore;
                prevScore = curScore;
            }else if(operations[i] == "C"){
                curScore = prevScore;
                curPoints -= curScore;
                prevPrevScore = prevScore;
                prevScore = -curScore;
            }else if(operations[i] == "D"){
                curScore = prevScore * 2;
                curPoints += curScore;
                prevPrevScore = prevScore;
                prevScore = curScore;
            }else{
                curScore = int.Parse(operations[i]);
                curPoints += curScore;
                prevPrevScore = prevScore;
                prevScore = curScore;
            }
        }    

        return curPoints;    
    }
}