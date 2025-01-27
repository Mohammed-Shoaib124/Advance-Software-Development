using System;
public class Csharpproperties {
    public class Person{
   public string Name{
       get;set;
   }
   private int age;
   public int Age{
       get{return age;}
       set{
           if(value>0){
               age = value;
           }else{
               throw new ArgumentException("age cannot be negative");
           }
       }
   }}
   public static void Main(){
       Console.WriteLine("Enter the person's name :");
       string name = Console.ReadLine();
       Console.WriteLine("Enter the person's age :");
       int age = int.Parse(Console.ReadLine());
       Person p = new Person();
       p.Name = name;
       try{
           p.Age = age;
       }
       catch(ArgumentException e){
           Console.WriteLine($"Error:{e.Message}");
           return;
       }
       Console.WriteLine($"Name : {p.Name} Age : {p.Age}");
   } 
    
  
}