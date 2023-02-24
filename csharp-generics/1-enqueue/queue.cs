
public class Queue<T>
{
    public Node head { get; set; }
    
    public Node tail { get; set; }

    private int count;
    
    public String CheckType(){
        return typeof(T).ToString();
    }
    
    public void Enqueue(T value){
        Node n = new Node(value);
        if (count == 0){
            head = n;
            tail = n;
            head.next = null;
        }
        else{
            tail.next = n;
        }
        this.count += 1;
    }
    
    public int Count(){
        return this.count;
    }
    
    public class Node{

        private T value { get; set; }
        
        public Node next { get; set; }
        
        public Node(T value){
            this.value = value;
        }
    }
}
