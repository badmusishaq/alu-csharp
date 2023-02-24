
public class Queue<T>
{
    
    public Node head { get; set; }
    
    public Node tail { get; set; }
    
    public int count;
    
    public String CheckType(){
        return (typeof(T).ToString());
    }
    
    public void Enqueue(T value){
        Node n = new Node(value);
        if (count == 0){
            head = n;
            tail = n;
        }
        else{
            tail.next = n;
            tail = n;
        }
        this.count += 1;
    }
    
    public T Dequeue(){
        if (head == null){
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        T val = head.value;
        head = head.next;
        count -= 1;
        return (val);
    }
    
    public int Count(){
        return (this.count);
    }
    
    public class Node{
       
        public T value { get; set; } = default(T);

        public Node next { get; set; } = null;

        public Node(T value){
            this.value = value;
        }
    }
}
