﻿public abstract class Base{
    
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

public class Decoration : Base, IInteractive, IBreakable{
    
    public int durability { get; set; }
    
    public bool isQuestItem;
    
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false){
        if (durability <= 0){
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }
   
    public void Interact(){
        if (durability <= 0){
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem){
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        } else{
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
   
    public void Break(){
        durability -= 1;
        if (durability > 0){
            Console.WriteLine($"You hit the {name}. It cracks.");
        } else if (durability == 0){
            Console.WriteLine($"You smash the {name}. What a mess.");
        } else{
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}