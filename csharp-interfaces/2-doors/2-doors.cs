
public abstract class Base{
    
    public string name {get; set;}
    
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }
}

public interface IInteractive{
    void Interact();
}

public interface IBreakable{
    
    int durability { get; set; }
    
    void Break();
}

public interface ICollectable{
    bool isCollected { get; set; }
   
    void Collect();  
}

public class Door : Base, IInteractive{
    
    public Door(string Name="Door"){
        this.name = Name;
    }
    
    public void Interact(){
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}