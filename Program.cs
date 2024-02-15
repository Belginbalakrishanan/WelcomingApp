// See https://aka.ms/new-console-template for more information
using WelcomingApp;
Console.WriteLine("Welcome to Authentication app");

SignIn obj = new SignIn();

Console.WriteLine(obj.Authenticate("admin", "admin@123"));

