using System;
public class Dog:Animal,IPet{
    public override void MakeSound(){
        Console.WriteLine("Bark....");
    }
    
    public override void Describe(){
        Console.WriteLine("This is a dog");
    }
    
    public void Play(){
        Console.WriteLine("A dog is playing");
    }
}