using System;
using System.Collections.Generic;
public class Csharpoops {
   public static void Main(){
       
    Cat c = new Cat();
    c.Describe();
    c.MakeSound();
    c.Play();
    
    Dog d = new Dog();
    d.Describe();
    d.MakeSound();
    d.Play();
    
    List<Animal> list = new List<Animal>();
    list.Add(c);
    list.Add(d);
    
    foreach(Animal a in list){
        a.Describe();
        a.MakeSound();
    }
   } 
}