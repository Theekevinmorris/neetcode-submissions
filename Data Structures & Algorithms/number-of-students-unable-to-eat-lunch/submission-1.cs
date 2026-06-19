public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var stack = new Stack<int>();
        var queue = new Queue<int>();
        int circleStudents = 0;
        int squareStudents = 0;


        for(int i = sandwiches.Length - 1; i >= 0; i--){
            stack.Push(sandwiches[i]);
        }

        for(int i = 0; i < students.Length; i++){
            queue.Enqueue(students[i]);
            if (students[i] == 1){
                squareStudents++;
            } else{
                circleStudents++;
            }
        }

        while(stack.Count > 0){
            if (stack.Peek() == 1 && squareStudents == 0){
                return queue.Count;
            }

            if(stack.Peek() == 0 && circleStudents == 0){
                return queue.Count;
            }

            if(stack.Peek() == 1 && queue.Peek() == 1){
                stack.Pop();
                queue.Dequeue();
                squareStudents--;
            } else if (stack.Peek() == 0 && queue.Peek() == 0){
                stack.Pop();
                queue.Dequeue();
                circleStudents--;
            } else if(stack.Peek() != queue.Peek()){
                var student = queue.Dequeue();
                queue.Enqueue(student);
            }    

        }

        return 0;

    }
}