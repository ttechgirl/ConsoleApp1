// See https://aka.ms/new-console-template for more information

using System;

Console.WriteLine("Hello, Aisha!");
Console.Write("Hello, seyi!");
DateTime time = DateTime.Now.ToLocalTime();

Console.WriteLine("Current local time: " + time);
PureCsharp pureCsharp = new PureCsharp();
pureCsharp.Generator();


class  PureCsharp
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