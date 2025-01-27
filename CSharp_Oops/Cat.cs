using System;
public class Cat:Animal,IPet{
    public override void MakeSound(){
        Console.WriteLine("Meow....");
    }
    
    public override void Describe(){
        Console.WriteLine("This is a cat");
    }
    
    public void Play(){
        Console.WriteLine("Cat is fetching the ball");
    }
}