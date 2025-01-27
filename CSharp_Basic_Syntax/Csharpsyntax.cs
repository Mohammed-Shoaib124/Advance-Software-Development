using System;
class Csharpsyntax {
  public static void Main() {
    const string correct_username = "Shoaib";
    const string correct_password = "shoaib123";
    Console.WriteLine("Enter username : ");
    string username = Console.ReadLine();
    if(username == ""){
        throw new Exception("username cannot be empty");
    }
    Console.WriteLine("Enter password : ");
    string password = Console.ReadLine();
    if(password == ""){
        throw new Exception("password cannot be empty");
    }
    if(username== correct_username && password == correct_password){
        Console.WriteLine($"Welcome, {username}! You have successfully logged in." );
    }else{
         Console.WriteLine("Login failed. Please check your username and password. ");
    }
    
    
  }
}