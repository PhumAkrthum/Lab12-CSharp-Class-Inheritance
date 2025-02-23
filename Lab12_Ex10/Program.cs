// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
DerivedClass dc = new DerivedClass();
Console.WriteLine("Use Type Casting or Data Type Conversion");
((BaseClass)dc).Greeting(); 

Console.WriteLine("------------");
Console.WriteLine("Use as keyword");
(dc as BaseClass).Greeting();

class BaseClass
{
    public string Hello = "Hello From BaseClass";
    public void Greeting()
    {
        Console.WriteLine("This is method in BaseClass");
        Console.WriteLine(Hello);
    }

}
class DerivedClass : BaseClass
{
    public string Hello = "Hello From DerivedClass";
    public void Greeting()
    {
        Console.WriteLine("This is method in DerivedClass");
        Console.WriteLine(Hello);
    }
}