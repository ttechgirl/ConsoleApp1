// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using System;
using System.Reflection.Metadata.Ecma335;

//Console.WriteLine("Hello, Aisha!");
//Console.Write("Hello, seyi!");
//DateTime time = DateTime.Now.ToLocalTime();

//Console.WriteLine("Current local time: " + time);
//PureCsharp pureCsharp = new PureCsharp();
//pureCsharp.Generator();

//School school = new School();   //instatiation
//school.Student(); //invoke method 

//Academy academy = new Academy();
//academy.ClassRoom();

//Subjects.MatheMatics();

//ExtendedFamily extendedFamily = new ExtendedFamily();
//extendedFamily.GrandParents();

//Operators operators = new Operators();
//operators.MatheMatics();
//operators.Conditions();

Casting casting = new Casting();
casting.Conditions();



Zoo zoo = new Zoo();
zoo.Animal();

Zoo zoo1 = new Zoom(); //polymorphism
zoo1.Animal();

public class  PureCsharp
{
    public void Generator()
    {
        Console.WriteLine("Enter password");
        Console.WriteLine("=================");
        Console.WriteLine("Password must be 6 characters long");
        Console.WriteLine("=================");

        var password = Console.ReadLine();

        if(password != null && password.Length >= 6)
        {
            var guid = Guid.NewGuid().ToString("N")[2..6];
            int age = 5;
            var generatedPassword = password + " " + guid; //string concatenation
            Console.WriteLine($"Suggested password is {generatedPassword}"); //string interpolation
            return ;
        }
        else
        {
            Console.WriteLine("=================");
            Console.WriteLine("Wrong password format");
            return;
        }
    }
    
    

}

public class Zoo  //base
{
    public virtual void Animal()
    {
        Console.WriteLine("This is the base class");
    }
}

public  class Zoom : Zoo
{
    public override void Animal()
    {
        Console.WriteLine("This is the derived class");

    }

    // public abstract ISchools
    //{


    //}
}

   

 public interface ISchool 
{
    void Student();
    public string BookShop { get; set; }
   
}


class School : ISchool
{
    public string BookShop { get => BookShop; set => throw new NotImplementedException(); }

    public void Student()
    {
        var age = 40;
        var name = "Shola";

        Console.WriteLine($"Student name is {name}");

        //data types
        int blue = 100;
        string firstName = "Victoria";
        firstName = "Ajoke"; //reassignment
        char grade = 'A';
        Console.WriteLine($"Hello, {firstName} got {grade} in her english exam!"); //string interpolation
        Console.WriteLine($"{firstName} is got {blue} in her english exam!"); //string interpolation
        return;
    }

    public void Football()
    {
        //data types

        return;
    }

    //nested class
    public class Book
    {

    }

}




